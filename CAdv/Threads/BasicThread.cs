using System;
using System.Threading;

namespace ThreadPractice
{
  public class BasicThread
  {
    public static void Run()
    {
      Thread thread = new Thread(PrintNumbers);
      thread.Start();
    }

    static void PrintNumbers()
    {
      for (int i = 1; i <= 5; i++)
      {
        Console.WriteLine($"Thread: {i}");
        Thread.Sleep(500);
      }
    }
  }
}
