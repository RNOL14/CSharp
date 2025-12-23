using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
  public class BasicAsync
  {
    public static async Task Run()
    {
      Console.WriteLine("Starting async task...");
      await Task.Delay(2000);
      Console.WriteLine("Async task completed");
    }
  }
}
