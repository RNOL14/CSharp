using System;
using System.Threading.Tasks;

namespace TaskProgramming
{
  public class TaskRun
  {
    public static async Task Run()
    {
      Console.WriteLine("Starting background task...");

      await Task.Run(() =>
      {
        // Simulate heavy work
        for (int i = 1; i <= 3; i++)
        {
          Console.WriteLine($"Processing step {i}");
          Task.Delay(1000).Wait();
        }
      });

      Console.WriteLine("Background task finished");
    }
  }
}
