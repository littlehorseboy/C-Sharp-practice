using System;

class Class
{
  static void Main()
  {
    Point p1 = new Point(0, 0);
    Point p2 = new Point(10, 20);

    Console.WriteLine(p1.x);
    Console.WriteLine(p2.x);
  }

  public class Point
  {
    public int x, y;
    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
  }
}
