using System;

class Do
{
  static void Main()
  {
    string s;

    do
    {
      s = Console.ReadLine();
      Console.WriteLine(s);
    } while (!string.IsNullOrEmpty(s));
  }
}
