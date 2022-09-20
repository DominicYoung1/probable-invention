using System;
using System.Collections.Generic;
using PaperTrader.User;
using PaperTrader.Data;

namespace PaperTrader
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailBrain.Run();
            Console.WriteLine("Hello World!");
            //List<StockDataBasket> stock = new List<StockDataBasket>();
            //MathBrain brain = new MathBrain(stock);
            //UserInfo myUser = new UserInfo(10000.00, 0, "Bob");
            //stock.Add(new StockDataBasket(new StockDataValues(new DateTime(2077, 1, 1), 25.25), "Jeffrey"));
            //StockDataValues testValue = new StockDataValues(new DateTime(2077, 1, 1), 25.25);
            //StockDataBasket testBasket = new StockDataBasket(new StockDataValues(new DateTime(2077, 1, 1), 25.25), "Jeffrey");
            //Console.WriteLine(testValue.value);
            //Console.WriteLine(testBasket.name);
            //Console.WriteLine(stock[0].value.date);
            //Console.WriteLine(stock[0].name);
            //stock.Add(new StockDataBasket(new StockDataValues(new DateTime(2077, 2, 1), 125.25), "Jeffrey"));
            //stock.Add(new StockDataBasket(new StockDataValues(new DateTime(2077, 3, 1), 225.25), "Jeffrey"));
            //stock.Add(new StockDataBasket(new StockDataValues(new DateTime(2077, 4, 1), 325.25), "Jeffrey"));
            //stock.Add(new StockDataBasket(new StockDataValues(new DateTime(2077, 5, 1), 425.25), "Jeffrey"));
            //stock.Add(new StockDataBasket(new StockDataValues(new DateTime(2077, 6, 1), 525.25), "Jeffrey"));
            //stock.Add(new StockDataBasket(new StockDataValues(new DateTime(2077, 7, 1), 625.25), "Jeffrey"));
            //brain.DoPurchase(myUser, stock);
            //Console.WriteLine(myUser.GetBalacne());
            //Console.WriteLine(myUser.GetCollection());

        }
    }
}
