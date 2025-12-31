using System;
using System.Threading;
using System.Threading.Tasks;
using AsyncPublish;

class Program
{
  static async Task Main()
  {
    AsyncEventPublisher publisher = new AsyncEventPublisher();
    AsyncEventSubscriber subscriber = new AsyncEventSubscriber();

    publisher.OnWorkCompleted += subscriber.HandleAsync;
    publisher.OnWorkCompleted += subscriber.LogAsync;

    using CancellationTokenSource cts = new CancellationTokenSource();

    // Cancel after 3 seconds
    cts.CancelAfter(3000);

    try
    {
      await publisher.DoWorkAsync(cts.Token);
    }
    catch (OperationCanceledException)
    {
      Console.WriteLine("Publisher operation cancelled");
    }
  }
}
