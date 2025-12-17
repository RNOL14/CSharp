
namespace encapsulation
{
  public class BankAccount
  {
    // Private fields (data hiding)
    private string accountHolder;
    private double balance;

    // Constructor
    public BankAccount(string name, double initialBalance)
    {
      accountHolder = name;
      balance = initialBalance;
    }

    // Public method to deposit money
    public void Deposit(double amount)
    {
      if (amount > 0)
      {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
      }
    }

    // Public method to withdraw money
    public void Withdraw(double amount)
    {
      if (amount > 0 && amount <= balance)
      {
        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
      }
      else
      {
        Console.WriteLine("Insufficient balance");
      }
    }

    // Public method to view balance
    public void ShowBalance()
    {
      Console.WriteLine($"Account Holder: {accountHolder}");
      Console.WriteLine($"Current Balance: {balance}");
    }
  }
}