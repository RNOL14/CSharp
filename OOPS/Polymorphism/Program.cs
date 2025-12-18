using Polymorphism;

class Program
{
  static void Main()
  {
    Shape shape1 = new Shape();
    Shape shape2 = new Circle();
    Shape shape3 = new Rectangle();

    shape1.Draw();
    shape2.Draw();
    shape3.Draw();
  }
}