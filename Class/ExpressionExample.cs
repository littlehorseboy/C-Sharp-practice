using System;
using System.Collections.Generic;
using Custom.Expression;
// csc /r:.\Expression.dll .\ExpressionExample.cs
class ExpressionExample
{
  public static void ExampleUsage()
  {
    Expression e = new Operation(
      new VariableReference("x"),
      '*',
      new Operation(
        new VariableReference("y"),
        '+',
        new Constant(2)
      )
    );

    Dictionary<string, object> vars = new Dictionary<string, object>();
    vars["x"] = 3;
    vars["y"] = 5;
    Console.WriteLine(e.Evaluate(vars));
    vars["x"] = 1.5;
    vars["y"] = 9;
    Console.WriteLine(e.Evaluate(vars));
  }
  
  static void Main()
  {
    ExampleUsage();
  }
}
