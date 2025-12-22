using System;

namespace Delegates
{
  // Custom delegate
  public delegate void MessageDelegate(string message);

  public class BasicDelegate
  {
    public static void Run()
    {
      Console.WriteLine("Basic Delegate");

      MessageDelegate del = ShowMessage;
      del("Hello from custom delegate");
    }

    static void ShowMessage(string msg)
    {
      Console.WriteLine(msg);
    }
  }
}
