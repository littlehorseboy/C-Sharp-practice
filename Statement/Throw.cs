using System;

class Throw
{
  static void Main()
  {
    string[] args = new string[2] { "8", "4" };
    // string[] args = new string[3];

    Throw t = new Throw();

    try
    {
      if (args.Length != 2)
      {
        throw new InvalidOperationException("Two numbers required");
      }
      double x = double.Parse(args[0]);
      double y = double.Parse(args[1]);
      Console.WriteLine(t.Divide(x, y));
    }
    catch (InvalidOperationException e)
    {
      Console.WriteLine(e.Message);
    }
    finally
    {
      Console.WriteLine("Good bye!");
    }
  }

  public double Divide(double x, double y)
  {
    if (y == 0)
      throw new DivideByZeroException();

    return x / y;
  }
}
