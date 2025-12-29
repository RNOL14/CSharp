using System.Threading.Tasks;
using AsyncTaskPractice;

class Program
{
  static async Task Main()
  {
    AsyncEventPublisher publisher = new AsyncEventPublisher();
    AsyncEventSubscriber subscriber = new AsyncEventSubscriber();

    publisher.OnWorkCompleted += subscriber.HandleWorkCompletedAsync;
    publisher.OnWorkCompleted += subscriber.LogAsync;

    await publisher.DoWorkAsync();
  }
}
