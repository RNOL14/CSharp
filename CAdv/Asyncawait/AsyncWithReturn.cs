using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
  public class AsyncWithReturn
  {
    public static async Task<int> GetNumberAsync()
    {
      await Task.Delay(1500);
      return 42;
    }
  }
}
