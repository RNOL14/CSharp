using System;
using System.Threading;

namespace ThreadPractice
{
  public class MultipleThreads
  {
    public static void Run()
    {
      Thread t1 = new Thread(() => Print("Thread 1"));
      Thread t2 = new Thread(() => Print("Thread 2"));

      t1.Start();
      t2.Start();
    }

    static void Print(string name)
    {
      for (int i = 1; i <= 3; i++)
      {
        Console.WriteLine($"{name}: {i}");
        Thread.Sleep(500);
      }
    }
  }
}
