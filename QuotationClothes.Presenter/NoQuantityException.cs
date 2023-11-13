namespace QuotationClothes.Presenter
{
    public class NoQuantityException : Exception
    {
        public NoQuantityException() { }
        public NoQuantityException(string message) : base(message) { }
    }
}
