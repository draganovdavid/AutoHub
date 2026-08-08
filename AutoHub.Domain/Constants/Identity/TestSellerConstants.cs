namespace AutoHub.Domain.Constants.Identity
{
    public static class TestSellerConstants
    {
        // Фиксиран тестов SellerId — само докато няма реален JWT auth.
        // Заменям го с ICurrentUserService, извлечен от claims, при auth фазата.
        public static readonly Guid TestSellerId = new("11111111-1111-1111-1111-111111111111");
    }
}