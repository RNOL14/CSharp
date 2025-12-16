namespace CSharpBasics;

public class collections
{
  public static void Run()
  {
    // Array
    string[] fruits = { "Apple", "Banana", "Cherry" };
    Console.WriteLine("Fruits:");
    foreach (string fruit in fruits)
    {
      Console.WriteLine(fruit);
    }


    int[] num = { 10, 20, 30 };

    Console.WriteLine("ARRAY:");
    foreach (int n in num)
    {
      Console.WriteLine(n);
    }

    // List
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    Console.WriteLine("Numbers:");
    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }

    // Dictionary
    Dictionary<string, int> ages = new Dictionary<string, int>
    {
      { "Alice", 30 },
      { "Bob", 25 },
      { "Charlie", 35 }
    };
    Console.WriteLine("Ages:");
    foreach (var kvp in ages)
    {
      Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
  }
}