// Base class representing a person
namespace inheritance
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayBasic()
    {
      Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
  }
}