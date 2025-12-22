using System;

namespace Generics
{
  public class Box<T>
  {
    public T Value { get; set; }

    public Box(T value)
    {
      Value = value;
    }

    public void Show()
    {
      Console.WriteLine($"Box contains: {Value}");
    }
  }
}
