using System;
using StudentAttendanceManager;

class Program
{
  static void Main()
  {
    AttendanceService service = new AttendanceService();
    bool running = true;

    while (running)
    {
      Console.WriteLine("\n--- Attendance Menu ---");
      Console.WriteLine("1. Mark Present");
      Console.WriteLine("2. Mark Absent");
      Console.WriteLine("3. View Report");
      Console.WriteLine("4. Exit");
      Console.Write("Choose option: ");

      int choice = int.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1:
          Console.Write("Enter Student ID: ");
          int pid = int.Parse(Console.ReadLine());
          service.MarkAttendance(pid, true);
          break;

        case 2:
          Console.Write("Enter Student ID: ");
          int aid = int.Parse(Console.ReadLine());
          service.MarkAttendance(aid, false);
          break;

        case 3:
          service.ShowReport();
          break;

        case 4:
          running = false;
          Console.WriteLine("Exiting...");
          break;

        default:
          Console.WriteLine("Invalid choice.");
          break;
      }
    }
  }
}