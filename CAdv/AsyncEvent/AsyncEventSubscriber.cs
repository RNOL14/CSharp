using System;
using System.Threading.Tasks;

// Multiple Aync Event Subscribers
namespace AsyncTaskPractice
{
  public class AsyncEventSubscriber
  {
    public async Task HandleWorkCompletedAsync()
    {
      await Task.Delay(1000);
      Console.WriteLine("Subscriber 1 completed");
    }

    public async Task LogAsync()
    {
      await Task.Delay(500);
      Console.WriteLine("Subscriber 2 logged event");
    }
  }
}
