using System;
using System.Threading.Tasks;

namespace TaskProgramming
{
  public class ParallelTasks
  {
    public static async Task Run()
    {
      Console.WriteLine("Running tasks in parallel...");

      Task task1 = Task.Run(() =>
      {
        Console.WriteLine("Task 1 running");
        Task.Delay(2000).Wait();
      });

      Task task2 = Task.Run(() =>
      {
        Console.WriteLine("Task 2 running");
        Task.Delay(3000).Wait();
      });

      await Task.WhenAll(task1, task2);

      Console.WriteLine("All parallel tasks completed");
    }
  }
}
