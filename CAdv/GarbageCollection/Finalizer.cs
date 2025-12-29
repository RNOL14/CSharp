using System;

namespace GarbageCollection
{
  public class Finalizer
  {
    public static void Run()
    {
      CreateObjects();

      GC.Collect();
      GC.WaitForPendingFinalizers();

      Console.WriteLine("Finalizers executed.");
    }

    static void CreateObjects()
    {
      for (int i = 0; i < 3; i++)
      {
        new Resource();
      }
    }
  }

  class Resource
  {
    ~Resource()
    {
      Console.WriteLine("Finalizer called for Resource");
    }
  }
}
