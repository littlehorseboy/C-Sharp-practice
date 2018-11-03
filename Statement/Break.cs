using System;

class Break
{
  static void Main()
  {
    while (true)
    {
      string s = Console.ReadLine();
      if (string.IsNullOrEmpty(s))
      {
        break;
      }
      Console.WriteLine(s);
    }
  }
}
