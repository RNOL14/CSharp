using System;
namespace StudentAttendanceManager
{
  public interface IAttendance
  {
    void MarkAttendance(int studentId, bool present);
  }
}
