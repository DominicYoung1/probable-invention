using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader
{
    internal class Portfolio
    {
        string nasdaqID;
        string userID;
        double value;
        bool transactionType;  // 1 = buy, 0 = sell
        bool threshholdComparison;  // 1 = greater, 0 = lesser

        public Portfolio(string sID, string uID, double sValue, bool buyOrSell, bool greaterOrLesser)
        {
            nasdaqID = sID;
            userID = uID;
            value = sValue;
            transactionType = buyOrSell;
            threshholdComparison = greaterOrLesser;
        }
    }
}
