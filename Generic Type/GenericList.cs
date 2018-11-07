using System;

public class GenericList<T>
{
  public void Add(T input) { }
}

class TestGenericList
{
  static void Main()
  {
    GenericList<int> list1 = new GenericList<int>();
    list1.Add(1);

    GenericList<string> list2 = new GenericList<string>();
    list2.Add("");

    GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
    list3.Add(new ExampleClass());

    Console.WriteLine(list1);
    Console.WriteLine(list2);
    Console.WriteLine(list3);
  }

  private class ExampleClass { }
}
