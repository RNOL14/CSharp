namespace CSharpBasics;

public class conditional
{
  public static void Run()
  {
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
      Console.WriteLine("The number is positive.");
    }
    else if (number < 0)
    {
      Console.WriteLine("The number is negative.");
    }
    else
    {
      Console.WriteLine("The number is zero.");
    }
  }
}