using System;
using ExpenseTracker.Database;
using ExpenseTracker.Parsers;

namespace ExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            EntryDatabase entryDatabase = new EntryDatabase();
            Parser parser = new Parser(entryDatabase);

            ExpenseProcessor expenseProcessor = new ExpenseProcessor(parser);
            expenseProcessor.Process();
        }
    }
}
