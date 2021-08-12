

namespace BankApplication.Logger.Message
{
    public interface IMessage
    {
        public string SuccessfulDeposit();
        public string ViewBalance(double amount);
        public string ViewInterest(double amount);
        public string WithdrawSuccessful(double amount, double balance);
        public string LowBalance();
        public string InvalidAmount();
        public string FixedDepositTimeError();
    }
}
