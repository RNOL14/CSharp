using System;

namespace GarbageCollection
{
  public class GCBasics
  {
    public static void Run()
    {
      Console.WriteLine("Creating objects...");

      for (int i = 0; i < 10000; i++)
      {
        var obj = new SampleObject(i);
      }

      Console.WriteLine("Objects created.");
      Console.WriteLine("Forcing Garbage Collection...");

      GC.Collect();
      GC.WaitForPendingFinalizers();

      Console.WriteLine("Garbage Collection completed.");
    }
  }

  class SampleObject
  {
    public int Id;

    public SampleObject(int id)
    {
      Id = id;
    }
  }
}
