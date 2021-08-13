using System;
using System.Collections.Generic;
using ExpenseTracker.Interfaces;

namespace ExpenseTracker.Database
{
    public interface IDatabase
    {
        bool AddEntry(IEntry entry);

        List<IEntry> ReturnOneType(EntryType etype);

        List<IEntry> ReturnAll();
    }
}
