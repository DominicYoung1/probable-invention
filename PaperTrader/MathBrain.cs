using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using PaperTrader.Data;
using PaperTrader.User;

//namespace PaperTrader
//{
//    class MathBrain
//    {
//        public List<StockDataBasket> list;


//        public MathBrain(List<StockDataBasket> l)
//        {
//            list = l;
//        }

//        public bool DecideShouldBuy(List<StockDataBasket> stockInfo)
//        {

//            double initalValue = 0;
//            for (int i = 0; i < stockInfo.Count(); i++)
//            {
//                double mValue = 0;
//                mValue = stockInfo[i].value.value;
//                initalValue += mValue;
//            }
//            double average = initalValue / stockInfo.Count();
//            if (average < 50)
//            {
//                return true;
//            }
//            else return false;
//        }

//        public void DoPurchase(UserInfo user, List<StockDataBasket> stock)
//        {
//            //double stockPrice = stock[stock.Count() - 1].value.value;
//            double stockPrice = stock[4].value.value;
//            user.BuyAtValue(stockPrice);
//        }

//        public void DoSale(UserInfo user, List<StockDataBasket> stock)
//        {
//            double stockPrice = stock[stock.Count() - 1].value.value;
//            user.SellAtValue(stockPrice);
//        }
//    }
//}
