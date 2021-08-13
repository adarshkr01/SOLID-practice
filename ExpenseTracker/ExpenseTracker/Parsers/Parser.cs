using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Database;
using ExpenseTracker.Interfaces;
using ExpenseTracker.EntryImplementation;

namespace ExpenseTracker.Parsers
{
    public class Parser : IParser
    {
        private double _amount;
        private string _memo;
        private DateTime _date;

        private IDatabase _database;
        public Parser(IDatabase database)
        {
            _database = database;
        }
        public void CreateExpense()
        {
            AskOptions();
            IEntry entry = new Entry(_amount, _memo, _date, EntryType.Expense);
            _database.AddEntry(entry);
        }

        public void CreateSaving()
        {
            AskOptions();
            IEntry entry = new Entry(_amount, _memo, _date, EntryType.Saving);
            _database.AddEntry(entry);
        }

        public void ViewAll()
        {
            List<IEntry> list = _database.ReturnAll();
            foreach(IEntry entry in list)
            {
                Console.WriteLine("\n{0}\nAmount: {1} || Date: {2}\nMemo: {3}",
                                    entry.EType, entry.Amount, entry.DateCreated, entry.Memo);
            }
        }

        public void ViewExpenses()
        {
            List<IEntry> list = _database.ReturnOneType(EntryType.Expense);
            Console.WriteLine("--- Expenses ---");
            foreach (IEntry entry in list)
            {
                Console.WriteLine("\nAmount: {1} || Date: {2}\nMemo: {3}",
                                    entry.EType, entry.Amount, entry.DateCreated, entry.Memo);
            }
        }

        public void ViewSavings()
        {
            List<IEntry> list = _database.ReturnOneType(EntryType.Saving);
            Console.WriteLine("--- Savings ---");
            foreach (IEntry entry in list)
            {
                Console.WriteLine("\nAmount: {1} || Date: {2}\nMemo: {3}",
                                    entry.EType, entry.Amount, entry.DateCreated, entry.Memo);
            }
        }

        private void AskOptions()
        {
            Console.Write("Enter Amount: ");
            _amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter Memo: ");
            _memo = Console.ReadLine();

            Console.WriteLine("\nEnter Date [DD/MM/YY]: ");
            string[] dateString = Console.ReadLine().Split('/');

            _date = new DateTime(Convert.ToInt32(dateString[2]),
                                         Convert.ToInt32(dateString[1]),
                                         Convert.ToInt32(dateString[0]));
        }
    }
}
