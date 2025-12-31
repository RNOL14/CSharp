using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPipelineProject
{
  public class FileLogger
  {
    public async Task LogAsync(string fileName, CancellationToken token)
    {
      await Task.Delay(300, token);
      Console.WriteLine($"[Logger] File processed: {fileName}");
    }
  }
}
