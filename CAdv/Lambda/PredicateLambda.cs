using System;

namespace Lambdas
{
  public class PredicateLambda
  {
    public static void Run()
    {
      Console.WriteLine("Predicate Lambda:");

      Predicate<int> isEven = number => number % 2 == 0;

      Console.WriteLine("Is 10 even? " + isEven(10));
      Console.WriteLine("Is 7 even? " + isEven(7));
    }
  }
}
