using System;

namespace Interface
{
  public class UPIPayment : IPayment
  {
    public void MakePayment(double amount)
    {
      Console.WriteLine($"Paid {amount} using UPI");
    }
  }
}