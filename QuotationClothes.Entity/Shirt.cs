using System;

namespace QuotationClothes.Entity
{
    public class Shirt : Garment
    {   
        public enum SleeveType
        {
            Short,
            Long
        };
        public enum NeckType
        {
            Mao,
            Common
        };
        public SleeveType Sleeves;
        public NeckType Necks;
        public Shirt(decimal unitsPrice, int quantityUnitsStock, string garmentId) : base(unitsPrice, quantityUnitsStock, garmentId)
        {
        }

        public override decimal CalculatePrice()
        {
            decimal price = UnitsPrice;
            if (IsSleeveShortStandart())
            {
                price -= (price * 0.10m / 100);
            }
            if (IsSleeveShortPremium())
            {
                price += (price * 0.20m / 100);
            }
            if (IsNeckMaoStandart())
            {
                price += (price * 0.03m / 100);
            }
            if (IsNeckMaoPremium())
            {
                price += (price * 0.33m / 100);

            }
            return price;
        }

        private bool IsSleeveShortStandart()
        {
            return Sleeves == SleeveType.Short && QualityGarments == QualityGarmentType.Standart;
        }
        private bool IsSleeveShortPremium()
        {
            return Sleeves == SleeveType.Short && QualityGarments == QualityGarmentType.Premium;
        }
        private bool IsNeckMaoStandart()
        {
            return Necks == NeckType.Mao && QualityGarments == QualityGarmentType.Standart;
        }
        private bool IsNeckMaoPremium()
        {
            return Necks == NeckType.Mao && QualityGarments == QualityGarmentType.Premium;
        }
    }
}
