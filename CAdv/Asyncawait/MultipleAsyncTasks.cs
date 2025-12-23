using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
  public class MultipleAsyncTasks
  {
    public static async Task Run()
    {
      Console.WriteLine("Running multiple async tasks...");

      Task task1 = Task.Delay(2000);
      Task task2 = Task.Delay(3000);

      await Task.WhenAll(task1, task2);

      Console.WriteLine("All async tasks completed");
    }
  }
}
