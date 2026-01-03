using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQPractice
{
  public class WhereSelect
  {
    public static void Run()
    {
      List<int> numbers = new List<int> { 10, 20, 30, 40 };

      var result = numbers
          .Where(n => n > 20)
          .Select(n => n * 2);

      Console.WriteLine("Filtered & transformed values:");
      foreach (var n in result)
      {
        Console.WriteLine(n);
      }
    }
  }
}
