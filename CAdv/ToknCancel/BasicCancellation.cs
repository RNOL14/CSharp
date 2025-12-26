using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class BasicCancellation
  {
    public static async Task Run()
    {
      CancellationTokenSource cts = new CancellationTokenSource();
      CancellationToken token = cts.Token;

      Task task = DoWorkAsync(token);

      // Cancel after 3 seconds
      await Task.Delay(3000);
      cts.Cancel();

      try
      {
        await task;
      }
      catch (OperationCanceledException)
      {
        Console.WriteLine("Task was cancelled");
      }
    }

    static async Task DoWorkAsync(CancellationToken token)
    {
      for (int i = 1; i <= 10; i++)
      {
        token.ThrowIfCancellationRequested();

        Console.WriteLine($"Working... step {i}");
        await Task.Delay(1000);
      }
    }
  }
}
