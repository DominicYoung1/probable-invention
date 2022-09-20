using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader
{
    internal class Margins
    {
        string nasdaqID;
        string userID;
        double value;
        bool transactionType; // 1 = buy, 0 = sell
        bool threshholdComparison; // 1 greater than, 0 = less than

        public Margins(string sID, string uID, double sValue, bool BuyOrSell, bool greaterOrLesser)
        {
            nasdaqID = sID;
            userID = uID;
            value = sValue;
            transactionType = BuyOrSell;
            threshholdComparison = greaterOrLesser;
        }
    }
}
