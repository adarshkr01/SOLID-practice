using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Interfaces;

namespace ExpenseTracker.EntryImplementation
{
    public class Entry : IEntry
    {
        public double Amount { get; set; }
        public string Memo { get; set; }
        public DateTime DateCreated { get; set; }
        public EntryType EType { get; set; }

        public Entry(double amount,
                     string memo,
                     DateTime dateCreated,
                     EntryType etype)
        {
            Amount = amount;
            Memo = memo;
            DateCreated = dateCreated;
            EType = etype;
        }
    }
}
