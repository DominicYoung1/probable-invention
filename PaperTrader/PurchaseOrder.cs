using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader
{
    internal class PurchaseOrder
    {
        string nasdaqID;
        string portfolioId;
        double purchasePrice;
        double quantity;

        public PurchaseOrder(string sID, string pID, double sPrice, double numberOf)
        {
            nasdaqID = sID;
            portfolioId = pID;
            purchasePrice = sPrice;
            quantity = numberOf;
        }
    }
}
