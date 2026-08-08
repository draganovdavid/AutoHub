using AutoHub.Domain.Enums;

namespace AutoHub.Api.Contracts.Listings
{
    public record CreateCarListingRequest(
        string Title,
        string? Description,
        decimal? Price,
        bool IsPriceOnRequest,
        bool WithVat,
        string PhoneNumber,
        int LocationId,
        int BrandId,
        int VehicleModelId,
        int ProductionYear,
        Month ProductionMonth,
        int Mileage,
        int Horsepower,
        int? EngineCapacity,
        string? VinNumber,
        int EngineTypeId,
        int TransmissionId,
        int EuroStandardId,
        int ColorId,
        int BodyTypeId,
        List<int> SelectedFeatureIds
    );
}