using AutoHub.Domain.Entities.Vehicles;

namespace AutoHub.Infrastructure.Persistence.Seed
{
    internal static class VehicleTypeSeedData
    {
        internal static readonly VehicleType[] Data =
        {
            new() { Id = 1, Name = "Автомобили и Джипове", Slug = "avtomobiliidjipove", IsActive = true },
            new() { Id = 2, Name = "Бусове", Slug = "busove", IsActive = true },
            new() { Id = 3, Name = "Камиони", Slug = "kamioni", IsActive = true },
            new() { Id = 4, Name = "Мотоциклети", Slug = "mototsikleti", IsActive = true },
            new() { Id = 5, Name = "Селскостопански", Slug = "selskostopanski", IsActive = true },
            new() { Id = 6, Name = "Индустриални", Slug = "industrialni", IsActive = true },
            new() { Id = 7, Name = "Кари", Slug = "kari", IsActive = true },
            new() { Id = 8, Name = "Каравани", Slug = "karavani", IsActive = true },
            new() { Id = 9, Name = "Яхти и Лодки", Slug = "yahtiilodki", IsActive = true },
            new() { Id = 10, Name = "Ремаркета", Slug = "remarketa", IsActive = true },
            new() { Id = 11, Name = "Велосипеди", Slug = "velosipedi", IsActive = true },
            new() { Id = 12, Name = "Части", Slug = "chasti", IsActive = true },
            new() { Id = 13, Name = "Аксесоари", Slug = "aksesoari", IsActive = true },
            new() { Id = 14, Name = "Гуми и джанти", Slug = "gumiidjanti", IsActive = true },
            new() { Id = 15, Name = "Купува", Slug = "kupuva", IsActive = true },
            new() { Id = 16, Name = "Услуги", Slug = "uslugi", IsActive = true }
        };
    }
}