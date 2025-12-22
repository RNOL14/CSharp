using System;

namespace Generics
{
  public class GenericClasses
  {
    public static void Run()
    {
      Console.WriteLine(" Generic Class:");

      Box<string> stringBox = new Box<string>("Generic Box");
      stringBox.Show();
    }
  }
}
