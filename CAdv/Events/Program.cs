using Events;

class Program
{
  static void Main()
  {
    EventPublisher publisher = new EventPublisher();
    EventSubscriber subscriber = new EventSubscriber();

    // Subscribe to event
    publisher.OnNotify += subscriber.HandleNotification;

    // Trigger work
    publisher.DoWork();
  }
}
