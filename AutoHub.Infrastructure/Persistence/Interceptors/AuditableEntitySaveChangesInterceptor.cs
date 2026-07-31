using AutoHub.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AutoHub.Infrastructure.Persistence.Interceptors
{
    public class AuditableEntitySaveChangesInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(
            DbContextEventData eventData,
            InterceptionResult<int> result)
        {
            UpdateEntities(eventData.Context);
            return base.SavingChanges(eventData, result);
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            UpdateEntities(eventData.Context);
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        private static void UpdateEntities(DbContext? context)
        {
            if (context is null)
            {
                return;
            }

            var utcNow = DateTime.UtcNow;

            foreach (var entry in context.ChangeTracker.Entries<IAuditable>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = utcNow;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = utcNow;
                        break;
                }
            }

            foreach (var entry in context.ChangeTracker.Entries<ISoftDeletable>())
            {
                if (entry.State != EntityState.Deleted)
                {
                    continue;
                }

                entry.Entity.IsDeleted = true;
                entry.Entity.DeletedAt = utcNow;

                // Оставям Unchanged вместо Modified — маркирам explicit
                // само реално променените колони, за да избегна full-row
                // UPDATE (риск от презаписване на паралелни промени по
                // други колони — виж коментара по-долу за причината).
                entry.State = EntityState.Unchanged;

                entry.Property(nameof(ISoftDeletable.IsDeleted)).IsModified = true;
                entry.Property(nameof(ISoftDeletable.DeletedAt)).IsModified = true;

                if (entry.Entity is IAuditable auditable)
                {
                    auditable.UpdatedAt = utcNow;
                    entry.Property(nameof(IAuditable.UpdatedAt)).IsModified = true;
                }
            }
        }
    }
}