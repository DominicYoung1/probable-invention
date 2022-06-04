using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.Data
{
    class DataBasket
    {
        public DataValue value;
        public string name;

        public DataBasket(DataValue d, string n)
        {
            value = d;
            name = n;
        }
    }
}
