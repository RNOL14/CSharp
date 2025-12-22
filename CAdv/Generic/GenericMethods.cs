using System;

namespace Generics
{
  public class GenericMethods
  {
    public static void Run()
    {
      Console.WriteLine("Generic Method:");

      PrintValue("Hello Generics");
      PrintValue(100);
    }

    public static void PrintValue<T>(T value)
    {
      Console.WriteLine(value);
    }
  }
}
