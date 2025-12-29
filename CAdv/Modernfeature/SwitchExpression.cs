using System;

namespace features
{
  public class SwitchExpression
  {
    public static void Run()
    {
      int day = 3;

      string result = day switch
      {
        1 => "Monday",
        2 => "Tuesday",
        3 => "Wednesday",
        _ => "Unknown"
      };

      Console.WriteLine(result);
    }
  }
}
