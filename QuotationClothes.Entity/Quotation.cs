
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuotationClothes.Entity
{
    public class Quotation
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int SellerId { get; set; }
        public string GarmentId { get; set; }
        public int QuantityUnitsQuoted { get; set; }
        public decimal ResultCalculateQuotation { get; set; }
        
        public Garment Garment { get; }
        public Quotation() { }
        public Quotation(DateTime date, int sellerId, string garmentId, Garment garment, int quantityUnitsQuoted)
        {
            Date = date;
            SellerId = sellerId;
            GarmentId = garmentId;
            Garment = garment;
            QuantityUnitsQuoted = quantityUnitsQuoted;
            ResultCalculateQuotation = CalculateQuotation();
        }
        
       


        private decimal CalculateQuotation()
        {
            return Garment.CalculatePrice();
        }     
    }
}
