using Interface;

class Program
{
  static void Main()
  {
    IPayment payment1 = new CreditCardPayment();
    IPayment payment2 = new UPIPayment();

    payment1.MakePayment(500);
    payment2.MakePayment(1200);
  }
}