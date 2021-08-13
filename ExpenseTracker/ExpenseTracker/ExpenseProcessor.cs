using System;
using ExpenseTracker.Parsers;

namespace ExpenseTracker
{
    public class ExpenseProcessor
    {
        private IParser _parser;

        public ExpenseProcessor(IParser parser)
        {
            _parser = parser;
        }

        public void Process()
        {
            Console.WriteLine("--- Expense Tracker ---");

            while (true)
            {
                Console.WriteLine(
                    "\n1. Add Expense\t2. View Expenses\n3. Add Saving\t4. View Savings\n5. Show All\t6. Exit");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            _parser.CreateExpense();
                            break;

                        case 2:
                            _parser.ViewExpenses();
                            break;

                        case 3:
                            _parser.CreateSaving();
                            break;

                        case 4:
                            _parser.ViewSavings();
                            break;

                        case 5:
                            _parser.ViewAll();
                            break;

                        case 6:
                            Console.WriteLine("\n--- Thank you for using the Application ---");
                            Environment.Exit(0);
                            break;

                        default:
                            throw new FormatException();
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid Choice!");
                }

                Console.WriteLine("\nTry Again? [Y/N]");
                string tryAgain = Console.ReadLine().ToUpper();

                if (!tryAgain.Equals("Y"))
                {
                    Console.WriteLine("\n--- Thank you for using the Application ---");
                    break;
                }
            }
        }
    }
}
