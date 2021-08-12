using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Logger.Message
{
    public class EnglishMessages : IMessage
    {
        public string InvalidAmount()
        {
            return "Invalid Amount";
        }

        public string LowBalance()
        {
            return "Your Balance is low";
        }

        public string SuccessfulDeposit()
        {
            return "Your Deposit was successful";
        }

        public string ViewBalance(double amount)
        {
            return "Your Balance: " + amount;
        }

        public string ViewInterest(double amount)
        {
            return "Your Interest: " + amount;
        }

        public string WithdrawSuccessful(double amount, double balance)
        {
            return "You have successfully withdrawn: " + amount + "\nCurrent Balance: " + balance;
        }
    }
}
