using System;
using System.Threading.Tasks;
using AsyncAwait;

class Program
{
  static async Task Main()
  {
    // await BasicAsync.Run();

    int number = await AsyncWithReturn.GetNumberAsync();
    Console.WriteLine("Returned value: " + number);

    await MultipleAsyncTasks.Run();
  }
}
