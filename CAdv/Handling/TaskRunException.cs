using System;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class TaskRunException
  {
    public static async Task Run()
    {
      try
      {
        await Task.Run(() =>
        {
          throw new InvalidOperationException("Error inside Task.Run");
        });
      }
      catch (Exception ex)
      {
        Console.WriteLine("Caught Task.Run exception: " + ex.Message);
      }
    }
  }
}
