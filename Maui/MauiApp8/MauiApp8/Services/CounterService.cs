namespace MauiApp8.Services;

public class CounterService : ICounterService
{
  private int _count = 0;

  public int GetCount()
  {
    return _count;
  }

  public int Increment()
  {
    _count++;
    return _count;
  }
}
