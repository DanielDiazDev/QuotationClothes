using static QuotationClothes.Entity.Shirt;

namespace QuotationClothes.Entity
{
    public class Pant : Garment
    {
        

        public enum PantsType
        {
            Commom,
            Chupin
        };
        public PantsType Pants { get;set; }
        public Pant(decimal unitsPrice, int quantityUnitsStock, string garmentId) : base(unitsPrice, quantityUnitsStock, garmentId)
        {
        }

        public override decimal CalculatePrice()
        {
            decimal price = UnitsPrice;
            if (IsChupinStandart())
            {
                price -= (price * 0.12m / 100);
            }
            if (IsChupinPremium())
            {
                price += (price * 0.18m / 100);
            }
            return price;
        }
        private bool IsChupinStandart()
        {
            return Pants == PantsType.Chupin && QualityGarments == QualityGarmentType.Standart;
        }
        private bool IsChupinPremium()
        {
            return Pants == PantsType.Chupin && QualityGarments == QualityGarmentType.Premium;
        }
    }
}