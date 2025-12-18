using System;
// Base class representing a shape
namespace Polymorphism
{
  public class Shape
  {
    public virtual void Draw()
    {
      Console.WriteLine("Drawing a shape");
    }
  }
}