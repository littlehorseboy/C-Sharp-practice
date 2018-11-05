using System;

class Goto
{
  static void Main()
  {
    int[] args = new int[10];
    int i = 0;

    goto check;

    loop;

    Console.WriteLine(i++);

    check;
    
    if (i < args.Length)
    {
      goto loop;
    }
  }
}
