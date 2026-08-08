using AutoHub.Domain.Enums;
using MediatR;

namespace AutoHub.Application.Listings.Commands.CreateCarListing
{
    public record CreateCarListingCommand(
        // --- Listing ---
        string Title,
        string? Description,
        decimal? Price,
        bool IsPriceOnRequest,
        bool WithVat,
        string PhoneNumber,
        int LocationId,
        // Временно explicit, докато няма JWT auth.
        Guid SellerId,
        // --- Vehicle (base) ---
        int BrandId,
        int VehicleModelId,
        int ProductionYear,
        Month ProductionMonth,
        // --- Car-specific ---
        int Mileage,
        int Horsepower,
        int? EngineCapacity,
        string? VinNumber,
        int EngineTypeId,
        int TransmissionId,
        int EuroStandardId,
        int ColorId,
        int BodyTypeId,
        // --- Features ---
        List<int> SelectedFeatureIds
    ) : IRequest<Guid>;
}