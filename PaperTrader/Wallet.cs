using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader
{
    public class Wallet
    {
        double balance;
        double dailyLimit;
        double transactionLimit;
        double monthlyLimit;

        public Wallet(double uBalance, double uDLimit, double uTLimit, double uMLimit)
        {
            balance = uBalance;
            dailyLimit = uDLimit;
            transactionLimit = uTLimit;
            monthlyLimit = uMLimit;
        }
    }
}
