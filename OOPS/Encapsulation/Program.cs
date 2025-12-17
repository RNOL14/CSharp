
using encapsulation;

class Program
{
  static void Main()
  {
    BankAccount account = new BankAccount("Arnold", 5000);

    account.ShowBalance();
    account.Deposit(2000);
    account.Withdraw(1500);
    account.ShowBalance();

    // Not allowed (data is private)
    // account.balance = 10000;
  }
}
