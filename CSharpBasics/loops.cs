namespace CSharpBasics;

public class loops
{
  public static void Run()
  {
    // for loop
    Console.WriteLine("For Loop:");
    for (int i = 1; i <= 5; i++)
    {
      Console.WriteLine("i = " + i);
    }

    // while loop
    Console.WriteLine("While Loop:");
    int j = 1;
    while (j <= 5)
    {
      Console.WriteLine("j = " + j);
      j++;
    }

    // do-while loop
    Console.WriteLine("Do-While Loop:");
    int k = 1;
    do
    {
      Console.WriteLine("k = " + k);
      k++;
    } while (k <= 5);
  }
}