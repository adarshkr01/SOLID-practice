

namespace BankApplication.Logger.Message
{
    public interface IMessage
    {
        string SuccessfulDeposit();
        string ViewBalance(double amount);
        string ViewInterest(double amount);
        string WithdrawSuccessful(double amount, double balance);
        string LowBalance();
        string InvalidAmount();
        string FixedDepositTimeError();
        string WelcomeMessage();
        string AccountCreationMenu();
        string ThankyouMessage();
        string InvalidChoice();
    }
}
