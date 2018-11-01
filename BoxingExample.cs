using System;

class BoxingExample
{
  static void Main()
  {
    int i = 123;
    object o = i; // Boxing
    object a = "123" ;
    Console.WriteLine("object o.GetType() = " + o.GetType());
    Console.WriteLine("object a.GetType() = " + a.GetType());

    int j = (int)o; // Unboxing
    Console.WriteLine("int j = " + j);
  }
}
