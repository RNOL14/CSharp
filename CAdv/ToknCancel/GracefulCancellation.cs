using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class GracefulCancellation
  {
    public static async Task Run()
    {
      CancellationTokenSource cts = new CancellationTokenSource();

      Task task = ProcessAsync(cts.Token);

      await Task.Delay(2000);
      cts.Cancel();

      await task;
      Console.WriteLine("Task exited gracefully");
    }

    static async Task ProcessAsync(CancellationToken token)
    {
      while (!token.IsCancellationRequested)
      {
        Console.WriteLine("Working...");
        await Task.Delay(500);
      }
    }
  }
}
