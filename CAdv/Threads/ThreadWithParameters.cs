using System;
using System.Threading;

namespace ThreadPractice
{
  public class ThreadWithParameters
  {
    public static void Run()
    {
      Thread thread = new Thread(PrintMessage);
      thread.Start("Hello from thread");
    }

    static void PrintMessage(object message)
    {
      Console.WriteLine(message);
    }
  }
}
