using System;
using System.Threading.Tasks;

namespace AsyncTaskPractice
{
  public class AggregateExceptions
  {
    public static async Task Run()
    {
      Task t1 = Task.Run(() => throw new InvalidOperationException("Invalid operation"));
      Task t2 = Task.Run(() => throw new ArgumentException("Bad argument"));

      try
      {
        await Task.WhenAll(t1, t2);
      }
      catch (AggregateException ex)
      {
        foreach (var inner in ex.InnerExceptions)
        {
          Console.WriteLine("Caught: " + inner.Message);
        }
      }
    }
  }
}
