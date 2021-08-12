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

        public string FixedDepositTimeError()
        {
            return "Cannot Withdraw before the time expires in FD";
        }

        public string WelcomeMessage()
        {
            return "Welcome to ABC Bank";
        }

        public string AccountCreationMenu()
        {
            return "\n--- Create an Account ---\n\n1. Fixed Deposit\t2. Savings Account\n3. Exit";
        }

        public string ThankyouMessage()
        {
            return "\nThank you";
        }

        public string InvalidChoice()
        {
            return "\nInvalid Choice";
        }

        public string AccountMenu()
        {
            return "\n1. Deposit\t2. Withdraw\n3. Balance\t4. Interest\n5. Exit";
        }

        public string AskForAmount()
        {
            return "\nEnter amount: ";
        }

        public string TryAgain()
        {
            return "\nTry again? [Y/N]: ";
        }
    }
}
