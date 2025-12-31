using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPipelineProject
{
  public class FileNotifier
  {
    public async Task NotifyAsync(string fileName, CancellationToken token)
    {
      await Task.Delay(500, token);
      Console.WriteLine($"[Notifier] Notification sent for: {fileName}");
    }
  }
}
