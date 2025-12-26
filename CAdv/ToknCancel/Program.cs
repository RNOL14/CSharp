using System.Threading.Tasks;
using AsyncTaskPractice;

class Program
{
  static async Task Main()
  {
    await BasicCancellation.Run();
    await TaskRunCancellation.Run();
    await TimeoutCancellation.Run();
    await GracefulCancellation.Run();
  }
}



