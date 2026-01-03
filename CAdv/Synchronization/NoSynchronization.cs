using System;
using System.Threading;

namespace SynchronizationPractice
{
  public class NoSynchronization
  {
    static int counter = 0;

    public static void Run()
    {
      Thread t1 = new Thread(Increment);
      Thread t2 = new Thread(Increment);

      t1.Start();
      t2.Start();

      t1.Join();
      t2.Join();

      Console.WriteLine($"Final Counter (Wrong): {counter}");
    }

    static void Increment()
    {
      for (int i = 0; i < 100000; i++)
      {
        counter++;
      }
    }
  }
}
