using System;
using System.Threading;

namespace SynchronizationPractice
{
  public class Locks
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

      Console.WriteLine($"Final Counter (Correct): {counter}");
    }

    static void Increment()
    {
      for (int i = 0; i < 100000; i++)
      {
        lock (locker)
        {
          counter++;
        }
      }
    }
  }
}
