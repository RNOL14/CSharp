using System;

namespace Delegates
{
  public class PredicateDelegate
  {
    public static void Run()
    {
      Console.WriteLine("Predicate Delegate");

      Predicate<int> isEven = CheckEven;

      Console.WriteLine("Is 10 even? " + isEven(10));
      Console.WriteLine("Is 7 even? " + isEven(7));
    }

    static bool CheckEven(int number)
    {
      return number % 2 == 0;
    }
  }
}
