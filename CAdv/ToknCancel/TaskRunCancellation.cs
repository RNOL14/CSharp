using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class TaskRunCancellation
  {
    public static async Task Run()
    {
      CancellationTokenSource cts = new CancellationTokenSource();

      Task task = Task.Run(() =>
      {
        for (int i = 1; i <= 5; i++)
        {
          cts.Token.ThrowIfCancellationRequested();
          Console.WriteLine($"Processing {i}");
          Thread.Sleep(1000);
        }
      }, cts.Token);

      await Task.Delay(2500);
      cts.Cancel();

      try
      {
        await task;
      }
      catch (OperationCanceledException)
      {
        Console.WriteLine("Task.Run cancelled");
      }
    }
  }
}
