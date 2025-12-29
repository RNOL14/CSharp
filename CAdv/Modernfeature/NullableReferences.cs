using System;

namespace features
{
  public class NullaReferences
  {
    public static void Run()
    {
      string? name = null;

      if (name != null)
      {
        Console.WriteLine(name.Length);
      }
      else
      {
        Console.WriteLine("Name is null");
      }
    }
  }
}
