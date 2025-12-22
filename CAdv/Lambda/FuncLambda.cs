using System;

namespace Lambdas
{
  public class FuncLambda
  {
    public static void Run()
    {
      Console.WriteLine("Func Lambda:");

      Func<int, int, int> add = (a, b) => a + b;

      Console.WriteLine("Sum: " + add(10, 20));
    }
  }
}
