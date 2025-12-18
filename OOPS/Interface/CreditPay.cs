using System;

namespace Interface
{
  public class CreditCardPayment : IPayment
  {
    public void MakePayment(double amount)
    {
      Console.WriteLine($"Paid {amount} using Credit Card");
    }
  }
}