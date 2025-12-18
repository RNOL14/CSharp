using System;
// Derived class representing a rectangle
namespace Polymorphism
{
  public class Rectangle : Shape
  {
    public override void Draw()
    {
      Console.WriteLine("Drawing a Rectangle");
    }
  }
}