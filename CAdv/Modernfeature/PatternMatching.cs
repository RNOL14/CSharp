using System;

namespace features
{
  public class PatternMatching
  {
    public static void Run()
    {
      object value = 15;

      if (value is int number and > 10)
      {
        Console.WriteLine("Number is greater than 10");
      }
    }
  }
}
