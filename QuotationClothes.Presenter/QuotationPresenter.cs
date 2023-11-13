using QuotationClothes.Data;
using QuotationClothes.Entity;
using QuotationClothes.UseCase;
using static QuotationClothes.Entity.Shirt;
namespace QuotationClothes.Presenter
{
    public class QuotationPresenter
    {
        private IView _view;
        private Seller _seller;
        private Store _store;
        private List<Garment> _garments;
        private Quotation quotationCreated;
        private bool _isShort;
        private bool _isLong;
        private bool _isStandart;
        private bool _isPremium;

        private Shirt shirtShortMaoStandart;
        private Shirt shirtShortMaoPremium;
        private Shirt shirtShortCommomStandart;
        private Shirt shirtShortCommomPremium;
        private Shirt shirtLongMaoStandart;
        private Shirt shirtLongMaoPremium;
        private Shirt shirtLongCommomStandart;
        private Shirt shirtLongCommomPremium;
        private Pant pantChupinStandart;
        private Pant pantChupinPremium;
        private Pant pantCommomStandart;
        private Pant pantCommomPremium;
        private bool _isCommom;
        private bool _isChupin;
        private bool _isMao;
        private bool _isComomShirt;

        public void Initialize(IView view)
        {

            _view = view;
            _view.onShortSelected += ShortSelected;
            _view.onLongSelected += LongSelected;
            _view.onMaoSelected += MaoSelected;
            _view.onCommomShirtSelected += CommomShirtSelected;
            _view.onCommomSelected += CommomSelected;
            _view.onChupinSelected += ChupinSelected;
            _view.onStandartSelected += StandartSelected;
            _view.onPremiumSelected += PremiumtSelected;
            _view.onUnitsStock += StockAvailable;
            _view.onContize += Cotize;
            _seller = new Seller("Daniel", "Diaz", 48524245);
            _store = new Store("Ropa Patagonica", "Avenida 123");
            ShowSellerName();
            ShowSellerId();
            ShowStoreName();
            ShowDirection();
            SetGarments();
            _store.AddGarments(shirtShortMaoStandart);
            _store.AddGarments(shirtShortMaoPremium);
            _store.AddGarments(shirtShortCommomStandart);
            _store.AddGarments(shirtShortCommomPremium);
            _store.AddGarments(shirtLongMaoStandart);
            _store.AddGarments(shirtLongMaoPremium);
            _store.AddGarments(shirtLongCommomStandart);
            _store.AddGarments(shirtLongCommomPremium);
            _store.AddGarments(pantChupinStandart);
            _store.AddGarments(pantChupinPremium);
            _store.AddGarments(pantCommomStandart);
            _store.AddGarments(pantCommomPremium);


        }

        private void ShowSellerName()
        {
            _view.ShowName($"{_seller.Name} {_seller.LastName}");
        }
        private void ShowSellerId()
        {
            _view.ShowSellerId($"{_seller.SellerId}");
        }
        private void ShowStoreName()
        {
            _view.ShowStoreName($"{_store.Name}");
        }
        private void ShowDirection()
        {
            _view.ShowDirection($"{_store.Direction}");
        }
        private void SetGarments()
        {
            shirtShortMaoStandart = new Shirt(200.0m, 100, "Camisa Corta Mao Standart") { Necks = NeckType.Mao, Sleeves = SleeveType.Short, QualityGarments = Garment.QualityGarmentType.Standart };
            shirtShortMaoPremium = new Shirt(500.50m, 100, "Camisa Corta Mao Premium") { Necks = NeckType.Mao, Sleeves = SleeveType.Short, QualityGarments = Garment.QualityGarmentType.Premium };
            shirtShortCommomStandart = new Shirt(100.0m, 150, "Camisa Corta Comun Standart") { Necks = NeckType.Common, Sleeves = SleeveType.Short, QualityGarments = Garment.QualityGarmentType.Standart };
            shirtShortCommomPremium = new Shirt(150.0m, 150, "Camisa Corta Comun Premium") { Necks = NeckType.Common, Sleeves = SleeveType.Short, QualityGarments = Garment.QualityGarmentType.Premium };
            shirtLongMaoStandart = new Shirt(200.0m, 75, "Camisa Larga Mao Standart") { Necks = NeckType.Mao, Sleeves = SleeveType.Long, QualityGarments = Garment.QualityGarmentType.Standart };
            shirtLongMaoPremium = new Shirt(500.50m, 75, "Camisa Larga Mao Premium") { Necks = NeckType.Mao, Sleeves = SleeveType.Long, QualityGarments = Garment.QualityGarmentType.Premium };
            shirtLongCommomStandart = new Shirt(100.0m, 175, "Camisa Larga Comun Standart") { Necks = NeckType.Common, Sleeves = SleeveType.Long, QualityGarments = Garment.QualityGarmentType.Standart };
            shirtLongCommomPremium = new Shirt(150.0m, 175, "Camisa Larga Comun Premium") { Necks = NeckType.Common, Sleeves = SleeveType.Long, QualityGarments = Garment.QualityGarmentType.Premium };
            pantChupinStandart = new Pant(200.0m, 750, "Pantalon Chupin Standart") { Pants = Pant.PantsType.Chupin, QualityGarments = Garment.QualityGarmentType.Standart };
            pantChupinPremium = new Pant(500.50m, 750, "Pantalon Chupin Premium") { Pants = Pant.PantsType.Chupin, QualityGarments = Garment.QualityGarmentType.Premium };
            pantCommomStandart = new Pant(100.0m, 750, "Pantalon Comun Standart") { Pants = Pant.PantsType.Commom, QualityGarments = Garment.QualityGarmentType.Standart };
            pantCommomPremium = new Pant(150.0m, 750, "Pantalon Comun Premium") { Pants = Pant.PantsType.Commom, QualityGarments = Garment.QualityGarmentType.Premium };
        }
        private Garment GarmentSelected()
        {
            if (_isStandart)
            {
                if (_isShort)
                {
                    if (_isMao)
                    {
                        return shirtShortMaoStandart;
                    }
                    else
                    {
                        return shirtShortCommomStandart;
                    }
                }
                else if (_isLong)
                {
                    if (_isMao)
                    {
                        return shirtLongMaoStandart;
                    }
                    else
                    {
                        return shirtLongCommomStandart;
                    }
                }
                else if (_isChupin)
                {
                    return pantChupinStandart;
                }
                else
                {
                    return pantCommomStandart;
                }
            }
            else
            {
                if (_isShort)
                {
                    if (_isMao)
                    {
                        return shirtShortMaoPremium;
                    }
                    else
                    {
                        return shirtShortCommomPremium;
                    }
                }
                else if (_isLong)
                {
                    if (_isMao)
                    {
                        return shirtLongMaoPremium;
                    }
                    else
                    {
                        return shirtLongCommomPremium;
                    }
                }
                else if (_isChupin)
                {
                    return pantChupinPremium;
                }
                else
                {
                    return pantCommomPremium;
                }
            }

        }
        private void ShortSelected(object? sender, bool isCheck)
        {
            if (isCheck)
            {
                _isShort = true;
                StockAvailable(this, EventArgs.Empty);
                ShowUnitsPrice(this, EventArgs.Empty);
            }
            else
            {
                _isShort = false;

            }

        }
        private void LongSelected(object? sender, bool isCheck)
        {
            if (isCheck)
            {
                _isLong = true;
                StockAvailable(this, EventArgs.Empty);
                ShowUnitsPrice(this, EventArgs.Empty);

            }
            else
            {
                _isLong = false;

            }
        }
        private void MaoSelected(object? sender, bool isCheck)
        {
            if (isCheck)
            {
                _isMao = true;
                StockAvailable(this, EventArgs.Empty);
                ShowUnitsPrice(this, EventArgs.Empty);

            }
            else
            {
                _isMao = false;
            }
        }
        private void CommomShirtSelected(object? sender, bool isCheck)
        {
            if (isCheck)
            {
                _isComomShirt = true;
                StockAvailable(this, EventArgs.Empty);
                ShowUnitsPrice(this, EventArgs.Empty);

            }
            else
            {
                _isComomShirt = false;
            }
        }
        private void CommomSelected(object? sender, bool isCheck)
        {
            if (isCheck)
            {
                _isCommom = true;
                StockAvailable(this, EventArgs.Empty);
                ShowUnitsPrice(this, EventArgs.Empty);

            }
            else
            {
                _isCommom = false;
            }
        }
        private void ChupinSelected(object? sender, bool isCheck)
        {
            if (isCheck)
            {
                _isChupin = true;
                StockAvailable(this, EventArgs.Empty);
                ShowUnitsPrice(this, EventArgs.Empty);

            }
            else
            {
                _isChupin = false;
            }
        }
        private void StandartSelected(object? sender, bool isCheck)
        {
            if (isCheck)
            {
                _isStandart = true;
                StockAvailable(this, EventArgs.Empty);
                ShowUnitsPrice(this, EventArgs.Empty);

            }
            else
            {
                _isStandart = false;
            }
        }
        private void PremiumtSelected(object? sender, bool isCheck)
        {
            if (isCheck)
            {
                _isPremium = true;
                StockAvailable(this, EventArgs.Empty);
                ShowUnitsPrice(this, EventArgs.Empty);

            }
            else
            {
                _isPremium = false;
            }
        }
        private void ShowUnitsPrice(object? sender, EventArgs e)
        {
            var updateSock = new UpdateStock(GarmentSelected());
            var unitPrice = updateSock.GetUnitsPrice();
            _view.ShowUnitsPrice($"{unitPrice}");
        }
        private void StockAvailable(object? sender, EventArgs e)
        {
            var updateSock = new UpdateStock(GarmentSelected());
            var unitsStock = updateSock.Update();
            _view.ShowUnitsStocks($"{unitsStock}");
        }
        private void Cotize(object? sender, EventArgs e)
        {
            try
            {
                var createQuotation = new CreateQuotation(_seller);
                var selectedGarment = GarmentSelected();
                if (selectedGarment.DoNotStockAvailable())
                {
                    throw new NoStockException("No hay stock disponible para este producto.");
                }
                Create(createQuotation, selectedGarment);

               // AddToDataBase();

                
            }
            catch (NoStockException ex)
            {

                _view.ShowNoStockMessage($"Error: {ex.Message}");
            }

        }

        private void AddToDataBase()
        {
            try
            {
                
            }
            catch(ArgumentNullException ex)
            {
                _view.ShowArgumentNullMessage($"Error: {ex.Message}");
            }
            
        }

        private void Create(CreateQuotation createQuotation, Garment selectedGarment)
        {
            try
            {
                if (_view.QuantityToQuotize() == 0)
                {
                    throw new NoQuantityException("Necesita poner el minimo de cantidad para poder cotizar");
                }
                if (selectedGarment.IsQuantityQuotedMoreThanUnitsStock(_view.QuantityToQuotize()))
                {
                    throw new QuantityExceedsMaxException("Ha superado la cantidad maxima del stock de la prenda");
                }
                else
                {
                    quotationCreated = createQuotation.Create(selectedGarment.GarmentId, _view.QuantityToQuotize(), selectedGarment);
                    using (var context = new ApplicationDbContext())
                    {
                        context.Quotations.Entry(quotationCreated).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                        context.SaveChanges();
                    }

                    decimal totalPrice = quotationCreated.ResultCalculateQuotation * _view.QuantityToQuotize();

                    totalPrice = Math.Round(totalPrice, 2);
                    StockAvailable(this, EventArgs.Empty);
                    _view.ShowPrice($"{totalPrice}");
                }
            }
            catch(QuantityExceedsMaxException ex)
            {
                _view.ShowQuantityExceedsMaxMessage($"Error: {ex.Message}");
            }
            catch(NoQuantityException ex)
            {
                _view.ShowNoQuantityMessage($"Error: {ex.Message}");
                    
            }
            
        }
    }
    
}


