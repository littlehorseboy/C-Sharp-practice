using System;

class ConsoleExample
{
  // 參數陣列
  // params
  public class FakeConsole
  {
    public static void Write(string fmt, params object[] args)
    {
      Console.Write(fmt, args);
    }
    public static void WriteLine(string fmt, params object[] args)
    {
      Console.WriteLine(fmt, args);
    }
  }

  static void Main()
  {
    int x = 1, y = 2, z = 3;

    object[] args = new object[3];
    args[0] = x;
    args[1] = y;
    args[2] = z;

    FakeConsole.Write("FakeConsole:");
    FakeConsole.WriteLine("");
    FakeConsole.WriteLine("x={0} y={1} z={2}", x, y, z);
    FakeConsole.WriteLine("x={0} y={1} z={2}", args);

    Console.Write("Console:");
    Console.WriteLine("");
    Console.WriteLine("x={0} y={1} z={2}", x, y, z);
    Console.WriteLine("x={0} y={1} z={2}", args);
  }
}
