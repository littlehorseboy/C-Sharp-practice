using System;

class Extend
{
  public class Point
  {
    public int x, y;
    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
  }

  public class Point3D : Point
  {
    public int z;
    public Point3D(int x, int y, int z) : base(x, y)
    {
      this.z = z;
    }
  }

  static void Main()
  {
    Point a = new Point(10, 20);
    Console.WriteLine(a.x);
    Console.WriteLine(a.y);

    Point b = new Point3D(10, 20, 30);
    Console.WriteLine(b.x);
    Console.WriteLine(b.y);
    // Console.WriteLine(b.z); // 不包含 'z' 的定義 來接受類型 'Extend.Point'

    Point3D c = new Point3D(10, 20, 30);
    Console.WriteLine(c.x);
    Console.WriteLine(c.y);
    Console.WriteLine(c.z);
  }
}
