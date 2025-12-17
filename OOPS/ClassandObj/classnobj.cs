

namespace classnobj
{
  public class Employee
  {
    // Fields
    public string Name;
    public int Id;
    public double Salary;

    // Constructor
    public Employee(int id, string name, double salary)
    {
      Id = id;
      Name = name;
      Salary = salary;
    }

    // Method
    public void DisplayDetails()
    {
      Console.WriteLine($"ID: {Id}");
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"Salary: {Salary}");
      Console.WriteLine();
    }
  }
}
