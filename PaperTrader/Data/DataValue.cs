using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.Data
{
    class DataValue
    {
        public DateTime date;
        public double value;

        public DataValue(DateTime d, double v)
        {
            date = d;
            value = v;
        }
    }
}
