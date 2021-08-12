using System;
using BankApplication.Interfaces;
using BankApplication.Logger;
using BankApplication.Logger.Message;
using BankApplication.BankClasses;

namespace BankApplication
{
    public class BankProcessor
    {
        private ILogger _logger;
        private IMessage _message;

        public BankProcessor(ILogger logger, IMessage message)
        {
            _logger = logger;
            _message = message;
        }

        public void Process()
        {
            Console.WriteLine("Welcome to ABC Bank");

            Console.WriteLine("\n--- Create an Account ---\n\n1. Fixed Deposit\t2. Savings Account\n3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            IBank bank = null;

            switch(choice)
            {
                case 1:
                    bank = new FixedDepositAccount(_logger, _message);
                    break;

                case 2:
                    bank = new SavingsAccount(_logger, _message);
                    break;

                case 3:
                    _logger.LogMessage("\nThank you");
                    Environment.Exit(0);
                    break;

                default:
                    _logger.LogError("\nInvalid Choice");
                    Environment.Exit(0);
                    break;
            }

            while(true)
            {
                Console.WriteLine("\n1. Deposit\t2. Withdraw\n3. Balance\t4. Interest\n5. Exit");

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            _logger.LogMessage("\nEnter amount: ");
                            bank.Deposit(Convert.ToDouble(Console.ReadLine()));
                            break;

                        case 2:
                            _logger.LogMessage("\nEnter amount: ");
                            bank.Withdraw(Convert.ToDouble(Console.ReadLine()));
                            break;

                        case 3:
                            bank.ViewBalance();
                            break;

                        case 4:
                            bank.ViewInterest();
                            break;

                        case 5:
                            _logger.LogMessage("\nThank you");
                            Environment.Exit(0);
                            break;

                        default:
                            _logger.LogError("\nInvalid Choice");
                            Environment.Exit(0);
                            break;
                    }
                }

                catch(Exception e)
                {
                    _logger.LogMessage(e.Message);
                }

                _logger.LogMessage("\nTry again? [Y/N]: ");
                string tryAgain = Console.ReadLine().ToUpper();

                if (!tryAgain.Equals("Y"))
                {
                    _logger.LogMessage("\nThank you");
                    break;
                }
            }
        }
    }
}
