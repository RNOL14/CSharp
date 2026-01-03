using SynchronizationPractice;

class Program
{
  static void Main()
  {
    NoSynchronization.Run();
    Locks.Run();
    Monitors.Run();
    // Deadlocks.Run(); 
  }
}