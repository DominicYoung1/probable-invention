using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader
{
    public class StockPrice
    {
        string nasdaqID;
        double price;

        public StockPrice(string sID, double sPrice)
        {
            nasdaqID = sID;
            price = sPrice;
        }
    }
}
