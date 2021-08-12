using System;
using BankApplication.Logger;
using BankApplication.Logger.Message;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            EnglishMessages englishMessages = new EnglishMessages();

            BankProcessor bankProcessor = new BankProcessor(consoleLogger, englishMessages);
            bankProcessor.Process();
        }
    }
}
