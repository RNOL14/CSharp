using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQPractice
{
  public class BasicLinq
  {
    public static void Run()
    {
      List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

      var evenNumbers = numbers.Where(n => n % 2 == 0);

      Console.WriteLine("Even numbers:");
      foreach (var n in evenNumbers)
      {
        Console.WriteLine(n);
      }
    }
  }
}
