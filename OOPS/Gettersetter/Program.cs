// using gettersetter;

// class Program
// {
//   static void Main()
//   {
//     Person person = new Person();

//     // Setting values using setters
//     person.SetName("Arnold");
//     person.SetAge(22);

//     // Getting values using getters
//     Console.WriteLine("Name: " + person.GetName());
//     Console.WriteLine("Age: " + person.GetAge());

//     // Invalid age example
//     person.SetAge(-5);
//   }
// }

using props;
class Program
{
  static void Main()
  {
    Person person = new Person();

    // Setting values (setter)
    person.Name = "Arnold";
    person.Age = 22;

    // Getting values (getter)
    Console.WriteLine("Name: " + person.Name);
    Console.WriteLine("Age: " + person.Age);

    // Invalid value example
    person.Age = -5;
  }
}