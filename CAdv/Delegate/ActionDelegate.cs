using System;

namespace Delegates
{
  public class ActionDelegate
  {
    public static void Run()
    {
      Console.WriteLine("Action Delegate");

      Action<string> print = PrintMessage;
      print("Hello from Action delegate");
    }

    static void PrintMessage(string message)
    {
      Console.WriteLine(message);
    }
  }
}
