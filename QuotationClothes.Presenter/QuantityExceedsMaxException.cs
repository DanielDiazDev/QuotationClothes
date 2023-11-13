namespace QuotationClothes.Presenter
{
    public class QuantityExceedsMaxException : Exception
    {
        public QuantityExceedsMaxException() { }
        public QuantityExceedsMaxException(string message) : base(message) { }
    }
}
