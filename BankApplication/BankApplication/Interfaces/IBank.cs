using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Interfaces
{
    public interface IBank
    {
        void ViewBalance();
        void Deposit(double amount);
        void Withdraw(double amount);
        void ViewInterest();
    }
}
