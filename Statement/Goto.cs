using System;

class Goto
{
  static void Main()
  {
    int[] args = new int[5] { 100, 200, 300, 400, 500 };
    int i = 0;

    goto check;

  loop:

    Console.WriteLine(args[i++]);

  check:

    if (i < args.Length)
    {
      goto loop;
    }
  }
}
