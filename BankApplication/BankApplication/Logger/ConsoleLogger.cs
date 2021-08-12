using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("ERROR!\n" + message);
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
