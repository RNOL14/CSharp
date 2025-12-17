
namespace props
{
  public class Person
  {
    // Private fields
    private string name;
    private int age;

    // Property for Name
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    // Property for Age (with validation)
    public int Age
    {
      get { return age; }
      set
      {
        if (value > 0)
          age = value;
        else
          Console.WriteLine("Age must be greater than 0");
      }
    }
  }
}