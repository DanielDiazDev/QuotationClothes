using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotationClothes.Presenter
{
    public class NoStockException : Exception
    {
        public NoStockException() { }
        public NoStockException(string message) : base(message)
        {

        }
    }
}
