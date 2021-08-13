using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Parsers
{
    public interface IParser
    {
        void CreateExpense();
        void ViewExpenses();
        void CreateSaving();
        void ViewSavings();
        void ViewAll();
    }
}
