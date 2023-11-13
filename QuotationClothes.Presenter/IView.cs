namespace QuotationClothes.Presenter
{
    public interface IView
        {

            event EventHandler<bool> onShortSelected;
            event EventHandler<bool> onLongSelected;
            event EventHandler<bool> onMaoSelected;
            event EventHandler<bool> onCommomShirtSelected;
            event EventHandler<bool> onCommomSelected;
            event EventHandler<bool> onChupinSelected;
            event EventHandler<bool> onStandartSelected;
            event EventHandler<bool> onPremiumSelected;

            event EventHandler onUnitsStock;
            event EventHandler onContize;

            void ShowPrice(string v);
            int QuantityToQuotize();
            void ShowUnitsStocks(string v);
            void ShowName(string v);
            void ShowStoreName(string v);
            void ShowDirection(string v);
            void ShowSellerId(string v);
            void ShowUnitsPrice(string v);
            void ShowNoStockMessage(string v);
        void ShowQuantityExceedsMaxMessage(string v);
        void ShowArgumentNullMessage(string v);
        void ShowNoQuantityMessage(string v);
    }

    
}


