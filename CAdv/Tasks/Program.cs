using System;
using System.Threading.Tasks;
using TaskProgramming;

class Program
{
  static async Task Main()
  {
    // await TaskRun.Run();

    int result = await TaskReturn.CalculateSumAsync();
    Console.WriteLine("Calculated Sum: " + result);

    await ParallelTasks.Run();
  }
}
