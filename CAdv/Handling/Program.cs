using System.Threading.Tasks;
using AsyncTaskPractice;

class Program
{
  static async Task Main()
  {
    await AsyncException.Run();
    await TaskRunException.Run();
    await TaskWhenAllException.Run();
    await AggregateExceptions.Run();
  }
}


