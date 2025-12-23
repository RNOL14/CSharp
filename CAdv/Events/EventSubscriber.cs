using System;

namespace Events
{
  public class EventSubscriber
  {
    public void HandleNotification(string message)
    {
      Console.WriteLine("Subscriber received message: " + message);
    }
  }
}
