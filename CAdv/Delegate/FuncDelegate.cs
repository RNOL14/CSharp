using System;

namespace Delegates
{
  public class FuncDelegate
  {
    public static void Run()
    {
      Console.WriteLine("Func Delegate");

      Func<int, int, int> add = AddNumbers;
      int result = add(10, 20);

      Console.WriteLine("Result: " + result);
    }

    static int AddNumbers(int a, int b)
    {
      return a + b;
    }
  }
}
