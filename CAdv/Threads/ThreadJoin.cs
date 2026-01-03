using System;
using System.Threading;

namespace ThreadPractice
{
  public class ThreadJoin
  {
    public static void Run()
    {
      Thread thread = new Thread(Work);
      thread.Start();

      thread.Join(); // wait for thread to finish
      Console.WriteLine("Main thread continues");
    }

    static void Work()
    {
      Thread.Sleep(2000);
      Console.WriteLine("Thread work completed");
    }
  }
}
