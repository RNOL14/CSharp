using System;
using System.Threading;
using System.Threading.Tasks;
using AsyncPipelineProject;

class Program
{
  static async Task Main()
  {
    FileProcessor processor = new FileProcessor();
    FileLogger logger = new FileLogger();
    FileNotifier notifier = new FileNotifier();

    processor.OnFileProcessed += logger.LogAsync;
    processor.OnFileProcessed += notifier.NotifyAsync;

    using CancellationTokenSource cts = new CancellationTokenSource();

    // Optional cancellation after 6 seconds
    cts.CancelAfter(6000);

    string[] files =
    {
            "report.pdf",
            "image.png",
            "data.csv",
            "summary.txt"
        };

    try
    {
      await processor.ProcessFilesAsync(files, cts.Token);
    }
    catch (OperationCanceledException)
    {
      Console.WriteLine("\nProcessing was cancelled.");
    }
  }
}
