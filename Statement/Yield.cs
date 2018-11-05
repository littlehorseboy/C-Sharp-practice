using System;
using System.Collections.Generic;

class Yield
{
  static void Main()
  {
    Yield y = new Yield();

    foreach (int i in y.Range(-10, 10))
    {
      Console.WriteLine(i);
    }
  }

  private IEnumerable<int> Range(int a, int b)
  {
    for (int i = a; i < b; i++)
    {
      yield return i;
    }
    yield break;
  }
}
