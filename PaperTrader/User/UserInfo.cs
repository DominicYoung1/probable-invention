using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace PaperTrader.User
//{
//    public class UserInfo
//    {
//        // this class represents the overall info that has to do with the user. 
//        double balance; // This represents the users current balance within the system.
//        Dictionary<string, double[]> collection; /* this represents the users collective 'stock portfolio'. each stock or 'key' in the dictionary should be able to point to 
//                                                that stocks info or 'value' which should be list of doubles that contain the current price of the stock,
//                                                the amount of shares owned by the user and the total sum of the users investment in the stock as a whole.*/
                                                
//        string name;    // this represents whatever is used to identify the user ie (email address, username, or generated id).

//        public UserInfo(double b, Dictionary<string, double[]> d, string n)
//        {
//            balance = b;
//            collection = d;
//            name = n;
//        }

//        public void BuyAtValue(double stockPrice)
//        {
//            balance -= stockPrice;
//            collection++;
//        } 
//        public void SellAtValue(double stockPrice)
//        {
//            balance += stockPrice;
//            collection--;
//        }

//        public double GetBalacne()
//        {
//            return balance;
//        }
//        public int GetCollection()
//        {
//            return collection;
//        }
//    }
//}
