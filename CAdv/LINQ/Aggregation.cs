using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQPractice
{
  public class Aggregation
  {
    public static void Run()
    {
      List<int> numbers = new List<int> { 10, 20, 30 };

      Console.WriteLine("Count: " + numbers.Count());
      Console.WriteLine("Sum: " + numbers.Sum());
      Console.WriteLine("Average: " + numbers.Average());
    }
  }
}
