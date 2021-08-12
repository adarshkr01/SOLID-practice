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
            _logger.LogMessage(_message.WelcomeMessage());

            _logger.LogMessage(_message.AccountCreationMenu());

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
                    _logger.LogMessage(_message.ThankyouMessage());
                    Environment.Exit(0);
                    break;

                default:
                    _logger.LogError(_message.InvalidChoice());
                    Environment.Exit(0);
                    break;
            }

            while(true)
            {
                Console.WriteLine(_message.AccountMenu());

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            _logger.LogMessage(_message.AskForAmount());
                            bank.Deposit(Convert.ToDouble(Console.ReadLine()));
                            break;

                        case 2:
                            _logger.LogMessage(_message.AskForAmount());
                            bank.Withdraw(Convert.ToDouble(Console.ReadLine()));
                            break;

                        case 3:
                            bank.ViewBalance();
                            break;

                        case 4:
                            bank.ViewInterest();
                            break;

                        case 5:
                            _logger.LogMessage(_message.ThankyouMessage());
                            Environment.Exit(0);
                            break;

                        default:
                            _logger.LogError(_message.InvalidChoice());
                            Environment.Exit(0);
                            break;
                    }
                }

                catch(Exception e)
                {
                    _logger.LogError(e.Message);
                }

                _logger.LogMessage(_message.TryAgain());
                string tryAgain = Console.ReadLine().ToUpper();

                if (!tryAgain.Equals("Y"))
                {
                    _logger.LogMessage(_message.ThankyouMessage());
                    break;
                }
            }
        }
    }
}
