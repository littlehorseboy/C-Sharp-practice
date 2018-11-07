using System;

class Checked
{
  static void Main()
  {
    int x = int.MaxValue;

    Console.WriteLine(x);

    Console.WriteLine(x + 1);

    unchecked
    {
      Console.WriteLine(x + 1); // Overflow
    }

    checked
    {
      Console.WriteLine(x + 1); // Exception
    }
  }
}
