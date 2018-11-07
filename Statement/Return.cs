using System;

class Return
{
  static void Main()
  {
    Return r = new Return();

    Console.WriteLine(r.Add(1, 2));
    return;
  }

  private int Add(int a, int b)
  {
    return a + b;
  }
}
