using System;
// Derived class representing a circle
namespace Polymorphism
{
  public class Circle : Shape
  {
    public override void Draw()
    {
      Console.WriteLine("Drawing a Circle");
    }
  }
}