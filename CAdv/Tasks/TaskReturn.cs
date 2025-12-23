using System;
using System.Threading.Tasks;

namespace TaskProgramming
{
  public class TaskReturn
  {
    public static async Task<int> CalculateSumAsync()
    {
      return await Task.Run(() =>
      {
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
          sum += i;
        }
        return sum;
      });
    }
  }
}
