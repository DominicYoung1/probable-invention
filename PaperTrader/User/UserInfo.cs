using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.User
{
    public class UserInfo
    {
        double balance;
        int collection;
        string name;

        public UserInfo(double b, int i, string n)
        {
            balance = b;
            collection = i;
            name = n;
        }

        public void BuyAtValue(double stockPrice)
        {
            balance -= stockPrice;
            collection++;
        } 
        public void SellAtValue(double stockPrice)
        {
            balance += stockPrice;
            collection--;
        }

        public double GetBalacne()
        {
            return balance;
        }
        public int GetCollection()
        {
            return collection;
        }
    }
}
