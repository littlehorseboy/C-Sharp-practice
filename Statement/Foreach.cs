using System;
using System.Collections.Generic;

class Foreach
{
  static void Main()
  {
    List<string> args = new List<string>();
    Console.WriteLine(args.GetType());
    args.Add("123");
    args.Add("456");
    Console.WriteLine(args.ToString());

    /* foreach 陳述式會針對在型別實作 System.Collections.IEnumerable
       或 System.Collections.Generic.IEnumerable<T>
       介面的執行個體中每個元素，執行其中的陳述式或陳述式區塊。
    */
    foreach (string s in args)
    {
      Console.WriteLine(s);
    }
  }
}
