using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class TimeoutCancellation
  {
    public static async Task Run()
    {
      CancellationTokenSource cts = new CancellationTokenSource();
      cts.CancelAfter(2000); // auto cancel after 2 seconds

      try
      {
        await LongRunningTask(cts.Token);
      }
      catch (OperationCanceledException)
      {
        Console.WriteLine("Task cancelled due to timeout");
      }
    }

    static async Task LongRunningTask(CancellationToken token)
    {
      await Task.Delay(5000, token);
    }
  }
}
