using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader
{
    public class Stock
    {
        string cName;
        string nasdaqID;

        public Stock(string name, string sID)
        {
            cName = name;
            nasdaqID = sID;
        }
    }
}
