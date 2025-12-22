using System;

namespace Lambdas
{
  public class ActionLambda
  {
    public static void Run()
    {
      Console.WriteLine("Action Lambda:");

      Action<string> greet = name =>
      {
        Console.WriteLine("Hello " + name);
      };

      greet("Arnold");
    }
  }
}
