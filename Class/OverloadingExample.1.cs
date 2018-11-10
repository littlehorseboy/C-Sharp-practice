using System;

class OverloadingExample
{
  static void F<T>(T x)
  {
    Console.WriteLine(x.GetType());
    Console.WriteLine("F(<T>(T)");
  }
  public static void UsageExample()
  {
    // F();
    F(1);
    F(1.123);
  }
  static void Main()
  {
    UsageExample();
  }
}
