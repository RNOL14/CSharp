using System;

namespace GarbageCollection
{
  public class Disposable
  {
    public static void Run()
    {
      using (FileResource resource = new FileResource())
      {
        resource.Use();
      }

      Console.WriteLine("Resource disposed properly.");
    }
  }

  class FileResource : IDisposable
  {
    public void Use()
    {
      Console.WriteLine("Using file resource...");
    }

    public void Dispose()
    {
      Console.WriteLine("Disposing file resource");
    }
  }
}
