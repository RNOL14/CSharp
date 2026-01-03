using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQPractice
{
  public class Sorting
  {
    public static void Run()
    {
      List<int> numbers = new List<int> { 5, 2, 8, 1 };

      var sorted = numbers.OrderBy(n => n);

      Console.WriteLine("Sorted numbers:");
      foreach (var n in sorted)
      {
        Console.WriteLine(n);
      }
    }
  }
}
