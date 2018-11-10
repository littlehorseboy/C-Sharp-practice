using System;

class OverloadingExample
{
  static void F()
  {
    Console.WriteLine("F()");
  }
  static void F(int x)
  {
    Console.WriteLine("F(int)");
  }
  static void F(double x)
  {
    Console.WriteLine("F(double)");
  }
  public static void UsageExample()
  {
    F();
    F(1);
    F(1.123);
  }
  static void Main()
  {
    UsageExample();
  }
}
