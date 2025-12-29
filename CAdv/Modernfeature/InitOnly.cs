using System;

namespace features
{
  public class InitOnly
  {
    public static void Run()
    {
      Student student = new Student
      {
        Id = 1,
        Name = "Arnold"
      };

      Console.WriteLine($"{student.Id} - {student.Name}");
    }
  }

  public class Student
  {
    public int Id { get; init; }
    public string Name { get; init; }
  }
}
