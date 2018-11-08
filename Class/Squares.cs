using System;

class Squares
{
  public static void WriteSquares()
  {
    // 方法主體和區域變數
    int i = 0;
    int j;
    
    while (i < 10)
    {
      j = i * i;

      Console.WriteLine($"{i} x {i} = {j}");

      i = i + 1;

      if (i == 5)
      {
        return;
      }
    }
  }

  static void Main()
  {
    WriteSquares();

    Console.WriteLine("=== 程式結束 ===");
  }
}
