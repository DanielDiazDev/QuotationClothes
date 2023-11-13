namespace QuotationClothes.Entity
{
    public abstract class Garment
    {
        public enum QualityGarmentType
        {
            Standart,
            Premium
        };
        public QualityGarmentType QualityGarments { get; set; }
        public decimal UnitsPrice { get; set; }
        public int QuantityUnitsStock { get; set; }
        public string GarmentId { get; set; }

        protected Garment(decimal unitsPrice, int quantityUnitsStock, string garmentId)
        {
           UnitsPrice = unitsPrice;
            QuantityUnitsStock = quantityUnitsStock;
            GarmentId = garmentId;
        }

        public abstract decimal CalculatePrice(); 
       
        public bool DoNotStockAvailable()
        {
            return QuantityUnitsStock == 0;
        }
        public void RestQuantityOfStock(int quantity)
        {
            QuantityUnitsStock -= quantity;
        }
        public int GetQuantityStock()
        {
            int stock = QuantityUnitsStock;
            return stock;
        }
        public decimal GeUnitsPrice()
        {
            decimal unitsPrice = UnitsPrice;
            return unitsPrice;
        }
        public bool IsQuantityQuotedMoreThanUnitsStock(int quantity)
        {
            return quantity > QuantityUnitsStock;
        }
    }
}

