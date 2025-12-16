

namespace CSharpBasics
{
  public class input
  {
    public static void Run()
    {
      Console.Write("Enter your name: ");
      string name = Console.ReadLine();

      Console.Write("Enter your age: ");
      int age = int.Parse(Console.ReadLine());

      Console.WriteLine($"Name: {name}, Age: {age}");
    }
  }
}
