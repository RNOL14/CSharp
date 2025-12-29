using System;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class AsyncEventPublisher
  {
    // Async event using Func<Task>
    public event Func<Task>? OnWorkCompleted;

    public async Task DoWorkAsync()
    {
      Console.WriteLine("Publisher: Starting work...");
      await Task.Delay(2000);

      Console.WriteLine("Publisher: Work completed");

      if (OnWorkCompleted != null)
      {
        await OnWorkCompleted.Invoke();
      }
    }
  }
}
