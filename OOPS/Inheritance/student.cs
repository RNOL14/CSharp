// Derived class representing a student
namespace inheritance
{
  public class Student : Person
  {
    public string Course { get; set; }

    public void DisplayStudent()
    {
      // Accessing base class members
      DisplayBasic();
      Console.WriteLine($"Course: {Course}");
    }
  }
}