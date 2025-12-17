using inheritance;

class Program
{
  static void Main()
  {
    Student student = new Student();

    student.Name = "Arnold";
    student.Age = 22;
    student.Course = "Computer Science";

    student.DisplayStudent();
  }
}
