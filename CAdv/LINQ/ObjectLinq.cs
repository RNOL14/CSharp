using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQPractice
{
  public class ObjectLinq
  {
    public static void Run()
    {
      List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "David", Salary = 50000 },
                new Employee { Id = 2, Name = "Arnold", Salary = 30000 },
                new Employee { Id = 3, Name = "John", Salary = 60000 }
            };

      var highSalary = employees
          .Where(e => e.Salary > 40000)
          .Select(e => e.Name);

      Console.WriteLine("Employees with high salary:");
      foreach (var name in highSalary)
      {
        Console.WriteLine(name);
      }
    }
  }

  public class Employee
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
  }
}
