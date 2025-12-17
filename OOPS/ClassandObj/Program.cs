using classnobj;
class Program
{
  static void Main()
  {
    // Creating objects using constructor
    Employee emp1 = new Employee(101, "Austin", 45000);
    Employee emp2 = new Employee(102, "Promod", 52000);
    Employee emp3 = new Employee(103, "Spen", 2000);

    emp1.DisplayDetails();
    emp2.DisplayDetails();
    emp3.DisplayDetails();
  }
}
