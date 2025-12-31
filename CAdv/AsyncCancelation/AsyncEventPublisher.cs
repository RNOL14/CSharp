using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPublish
{
  public class AsyncEventPublisher
  {
    // Async event that supports cancellation
    public event Func<CancellationToken, Task>? OnWorkCompleted;

    public async Task DoWorkAsync(CancellationToken token)
    {
      Console.WriteLine("Publisher: Starting work...");
      await Task.Delay(2000, token);

      if (OnWorkCompleted != null)
      {
        var handlers = OnWorkCompleted
            .GetInvocationList()
            .Cast<Func<CancellationToken, Task>>();

        foreach (var handler in handlers)
        {
          try
          {
            await handler(token);
          }
          catch (OperationCanceledException)
          {
            Console.WriteLine("Subscriber cancelled");
          }
        }
      }

      Console.WriteLine("Publisher: Work finished");
    }
  }
}
