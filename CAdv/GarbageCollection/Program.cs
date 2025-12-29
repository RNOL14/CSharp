using System.Threading.Tasks;
using GarbageCollection;

class Program
{
  static async Task Main()
  {
    GCBasics.Run();
    Finalizer.Run();
    Disposable.Run();
  }
}