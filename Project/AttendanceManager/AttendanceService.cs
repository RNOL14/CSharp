using System;
using System.Collections.Generic;

namespace StudentAttendanceManager
{
  public class AttendanceService : IAttendance
  {
    private List<Student> students = new List<Student>();

    public AttendanceService()
    {
      students.Add(new Student(1, "Arnold", 22));
      students.Add(new Student(2, "David", 21));
      students.Add(new Student(3, "Emma", 23));
    }

    public void MarkAttendance(int studentId, bool present)
    {
      foreach (var student in students)
      {
        if (student.Id == studentId)
        {
          student.IsPresent = present;
          Console.WriteLine("Attendance updated.");
          return;
        }
      }
      Console.WriteLine("Student not found.");
    }

    public void ShowReport()
    {
      Console.WriteLine("\nAttendance Report:");
      foreach (var student in students)
      {
        Console.WriteLine($"{student.Id}. {student.Name} - {student.GetStatus()}");
      }
    }
  }
}