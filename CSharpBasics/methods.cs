namespace CSharpBasics;

public class methods
{
  public static void Run()
  {
    // Calling methods
    SayHello();
    PrintName("Arnold");
    int sum = AddNumbers(10, 20);
    Console.WriteLine("Sum = " + sum);

    CheckAge(16);
  }

  // Method with no parameters
  static void SayHello()
  {
    Console.WriteLine("Hello! Welcome to C# methods.");
  }

  // Method with parameters 
  static void PrintName(string name)
  {
    Console.WriteLine("Name: " + name);
  }

  // Method with return value
  static int AddNumbers(int a, int b)
  {
    return a + b;
  }

  // Method with conditional logic
  static void CheckAge(int age)
  {
    if (age >= 18)
      Console.WriteLine("Eligible to vote");
    else
      Console.WriteLine("Not eligible to vote");
  }


}
