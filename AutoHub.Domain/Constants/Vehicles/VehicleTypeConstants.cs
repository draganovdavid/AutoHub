namespace AutoHub.Domain.Constants.Vehicles
{
    public static class VehicleTypeConstants
    {
        public const int VehicleTypeNameMaxLength = 50;

        public const int VehicleTypeSlugMaxLength = 50;

        // Natural key, резолва се към реален Id по време на изпълнение —
        // устойчиво на бъдещи промени в реда на seed данните.
        public const string CarsVehicleTypeSlug = "avtomobiliidjipove";
    }
}