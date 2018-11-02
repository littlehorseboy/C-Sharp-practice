using System;

class If
{
  static void Main()
  {
    string[] args = new string[0];

    if (args.Length == 0)
    {
      Console.WriteLine("No arguments");
    }
    else
    {
      Console.WriteLine("One or more arguments");
    }
  }
}
