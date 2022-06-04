using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PaperTrader.Data;
using PaperTrader.User;

namespace PaperTrader
{
    class MathBrain
    {
        public List<DataBasket> list;


        public MathBrain(List<DataBasket> l)
        {
            list = l;
        }

        public bool DecideShouldBuy(List<DataBasket> stockInfo) //this used to be called fuckyoujeffrey
        {
            
            double initalValue = 0;
            for (int i = 0; i < stockInfo.Count(); i++)
            {
                double mValue = 0;
                mValue = stockInfo[i].value.value;
                initalValue += mValue;
            }
            double average = initalValue / stockInfo.Count();
            if (average < 50)
            {
                return true;
            } 
            else return false;
        }

        public void DoPurchase(UserInfo user, List<DataBasket> stock)
        {
            //double stockPrice = stock[stock.Count() - 1].value.value;
            double stockPrice = stock[4].value.value;
            user.BuyAtValue(stockPrice);
        }

        public void DoSale(UserInfo user, List<DataBasket> stock)
        {
            double stockPrice = stock[stock.Count()- 1].value.value;
            user.SellAtValue(stockPrice);
        }
    }
}
