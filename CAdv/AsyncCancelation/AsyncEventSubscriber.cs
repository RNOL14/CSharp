using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPublish
{
  public class AsyncEventSubscriber
  {
    public async Task HandleAsync(CancellationToken token)
    {
      for (int i = 1; i <= 5; i++)
      {
        token.ThrowIfCancellationRequested();
        Console.WriteLine($"Subscriber 1 processing step {i}");
        await Task.Delay(500, token);
      }
    }

    public async Task LogAsync(CancellationToken token)
    {
      await Task.Delay(1000, token);
      Console.WriteLine("Subscriber 2 logged event");
    }
  }
}
