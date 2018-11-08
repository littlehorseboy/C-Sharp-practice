// csc /r:Entity.dll .\EntityExample.cs
using System;
using FakeEntity.Serial;
class EntityExample
{
  static void Main()
  {
    Entity.SetNextSerialNo(1000);

    Entity e1 = new Entity();

    Entity e2 = new Entity();

    Console.WriteLine(e1.GetSerialNo());
    Console.WriteLine(e2.GetSerialNo());
    Console.WriteLine(Entity.GetNextSerialNo());
  }
}
