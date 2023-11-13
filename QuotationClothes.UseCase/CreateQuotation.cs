using QuotationClothes.Entity;


namespace QuotationClothes.UseCase
{
    public class CreateQuotation
    {
        private Seller _seller;

        public CreateQuotation(Seller seller)
        {
            _seller = seller;
        }

        public Quotation Create(string garmentId, int quantityToQuote, Garment garment)
        {
            DateTime date = DateTime.Now;
            var quotation = _seller.RealizeQuotation(date, _seller.SellerId, garmentId, quantityToQuote, garment);
            garment.RestQuantityOfStock(quantityToQuote);
            return quotation;
        }
    }
}
