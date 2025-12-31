using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPipelineProject
{
  public class FileProcessor
  {
    // Async event with cancellation support
    public event Func<string, CancellationToken, Task>? OnFileProcessed;

    public async Task ProcessFilesAsync(string[] files, CancellationToken token)
    {
      Console.WriteLine("Starting file processing...\n");

      foreach (var file in files)
      {
        token.ThrowIfCancellationRequested();

        Console.WriteLine($"Processing file: {file}");

        await Task.Run(async () =>
        {
          await Task.Delay(1000, token); // simulate work
        });

        if (OnFileProcessed != null)
        {
          var handlers = OnFileProcessed
              .GetInvocationList()
              .Cast<Func<string, CancellationToken, Task>>();

          await Task.WhenAll(handlers.Select(h => h(file, token)));
        }
      }

      Console.WriteLine("\nAll files processed.");
    }
  }
}
