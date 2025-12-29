using System;

namespace features
{
  public class Record
  {
    public static void Run()
    {
      Person p1 = new Person("Promod", 22);
      Person p2 = new Person("Promod", 22);

      Console.WriteLine(p1 == p2); // true
    }
  }

  public record Person(string Name, int Age);
}
