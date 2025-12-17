namespace gettersetter
{
  public class Person
  {
    // Private fields (data hiding)
    private string name;
    private int age;

    // Setter for Name
    public void SetName(string personName)
    {
      name = personName;
    }

    // Getter for Name
    public string GetName()
    {
      return name;
    }

    // Setter for Age
    public void SetAge(int personAge)
    {
      if (personAge > 0)
      {
        age = personAge;
      }
      else
      {
        Console.WriteLine("Age must be greater than 0");
      }
    }

    // Getter for Age
    public int GetAge()
    {
      return age;
    }
  }
}