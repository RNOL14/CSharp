using System;

namespace Lambdas
{
  public class BasicLambda
  {
    public static void Run()
    {
      Console.WriteLine("Basic Lambda:");

      // Lambda expression
      Func<int, int> square = x => x * x;

      Console.WriteLine("Square of 5: " + square(5));
    }
  }
}
