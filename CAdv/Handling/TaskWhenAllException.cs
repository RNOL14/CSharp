using System;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class TaskWhenAllException
  {
    public static async Task Run()
    {
      Task t1 = Task.Run(() => throw new Exception("Task 1 failed"));
      Task t2 = Task.Run(() => throw new Exception("Task 2 failed"));

      try
      {
        await Task.WhenAll(t1, t2);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Exception caught from Task.WhenAll:");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
