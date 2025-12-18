using Abstraction;

class Program
{
  static void Main()
  {
    // Cannot create object of abstract class
    Animal animal = new Dog();

    animal.MakeSound();
    animal.Sleep();
  }
}