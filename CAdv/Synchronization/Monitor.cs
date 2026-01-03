using System;
using System.Threading;

namespace SynchronizationPractice
{
  public class Monitors
  {
    static int counter = 0;
    static object locker = new object();

    public static void Run()
    {
      Thread t1 = new Thread(Increment);
      Thread t2 = new Thread(Increment);

      t1.Start();
      t2.Start();

      t1.Join();
      t2.Join();

      Console.WriteLine($"Final Counter (Monitor): {counter}");
    }

    static void Increment()
    {
      Monitor.Enter(locker);
      try
      {
        counter++;
      }
      finally
      {
        Monitor.Exit(locker);
      }
    }
  }
}
