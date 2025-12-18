using System;
namespace StudentAttendanceManager
{
  public class Student : Person
  {
    public int Id { get; set; }
    public bool IsPresent { get; set; }

    public Student(int id, string name, int age)
        : base(name, age)
    {
      Id = id;
      IsPresent = false;
    }

    public virtual string GetStatus()
    {
      return IsPresent ? "Present" : "Absent";
    }
  }
}
