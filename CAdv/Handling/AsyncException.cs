using System;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class AsyncException
  {
    public static async Task Run()
    {
      try
      {
        Console.WriteLine("Starting async operation...");
        await ThrowExceptionAsync();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Exception caught: " + ex.Message);
      }
    }

    static async Task ThrowExceptionAsync()
    {
      await Task.Delay(1000);
      throw new Exception("Something went wrong in async method");
    }
  }
}
