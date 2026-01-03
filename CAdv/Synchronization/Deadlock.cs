using System;
using System.Threading;

namespace SynchronizationPractice
{
  public class Deadlocks
  {
    static object lock1 = new object();
    static object lock2 = new object();

    public static void Run()
    {
      Thread t1 = new Thread(() =>
      {
        lock (lock1)
        {
          Thread.Sleep(100);
          lock (lock2)
          {
            Console.WriteLine("Thread 1 acquired both locks");
          }
        }
      });

      Thread t2 = new Thread(() =>
      {
        lock (lock2)
        {
          Thread.Sleep(100);
          lock (lock1)
          {
            Console.WriteLine("Thread 2 acquired both locks");
          }
        }
      });

      t1.Start();
      t2.Start();
    }
  }
}
