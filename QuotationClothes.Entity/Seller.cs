using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationClothes.Entity
{
    public class Seller
    {
        public string Name { get; }
        public string LastName { get; }
        public int SellerId { get; }
        public Quotation Quotation { get; }

        public Seller(string name, string lastName, int sellerId)
        {
            Name = name;
            LastName = lastName;
            SellerId = sellerId;
        }

        public Quotation RealizeQuotation(DateTime date, int sellerId, string garmentId, int quantityUnitsQuoted, Garment garment)
        {

            var quotation = new Quotation(date, sellerId, garmentId, garment, quantityUnitsQuoted);

            return quotation;
        }
        public void SaveHistorialQuotation()
        {

        }
    }
}
