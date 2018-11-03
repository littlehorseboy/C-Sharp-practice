using System;

class Continue
{
  static void Main()
  {
    string[] args = new string[4] { "/123", "456", "/789", "3345678" };

    for (int i = 0; i < args.Length; i++)
    {
      Console.WriteLine(args[i].StartsWith("/"));
    }
  }
}
