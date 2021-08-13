using System;

namespace ExpenseTracker.Interfaces
{
    public interface IEntry
    {
        public double Amount { get; set; }
        public string Memo { get; set; }
        public DateTime DateCreated { get; set; }
        public EntryType EType { get; set; }
    }
}
