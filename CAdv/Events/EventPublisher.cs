using System;

namespace Events
{
  public class EventPublisher
  {
    // Declaring an event using Action
    public event Action<string> OnNotify;

    public void DoWork()
    {
      Console.WriteLine("Publisher: Doing some work...");

      //  Raising the event
      OnNotify?.Invoke("Work completed successfully!");
    }
  }
}
