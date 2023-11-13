using QuotationClothes.Entity;


namespace QuotationClothes.UseCase
{
    public class UpdateStock
    {
        private Garment _garment;

        public UpdateStock(Garment garment)
        {
            _garment = garment;
        }

        public int Update()
        {
            return _garment.GetQuantityStock();
        }

        public decimal GetUnitsPrice()
        {
            return _garment.GeUnitsPrice();
        }
    }
}
