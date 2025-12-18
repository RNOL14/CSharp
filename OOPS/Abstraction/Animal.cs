using System;

namespace Abstraction
{
  public abstract class Animal
  {
    // Abstract method 
    public abstract void MakeSound();

    // Normal method
    public void Sleep()
    {
      Console.WriteLine("Animal is sleeping");
    }
  }
}
