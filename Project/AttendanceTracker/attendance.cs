using System;
using System.Collections.Generic;

namespace AttendanceTracker
{
  public class Attendance
  {
    public static void Run()
    {

      List<string> studentNames = new List<string>();
      List<bool> isPresent = new List<bool>();

      // Adding attendance data
      studentNames.Add("Arnold");
      isPresent.Add(true);

      studentNames.Add("David");
      isPresent.Add(false);

      studentNames.Add("Promod");
      isPresent.Add(true);

      studentNames.Add("Austin");
      isPresent.Add(true);

      studentNames.Add("Spencer");
      isPresent.Add(false);

      // Counting present and absent students
      Console.WriteLine("Attendance Report:\n");

      int presentCount = 0;

      for (int i = 0; i < studentNames.Count; i++)
      {
        string status;

        if (isPresent[i])
        {
          status = "Present";
          presentCount++;
        }
        else
        {
          status = "Absent";
        }

        Console.WriteLine($"{i + 1}. {studentNames[i]} - {status}");
      }


      PrintSummary(presentCount, studentNames.Count);
    }

    // Printing summary of attendance
    static void PrintSummary(int present, int total)
    {
      Console.WriteLine("\nSummary:");
      Console.WriteLine($"Total Students: {total}");
      Console.WriteLine($"Present: {present}");
      Console.WriteLine($"Absent: {total - present}");
    }
  }
}