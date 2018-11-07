using System;
using System.Threading;

class Lock
{
  decimal balance;
  private readonly object sync = new object();
  public void Withdraw(decimal amount)
  {
    lock (sync)
    {
      if (amount > balance)
      {
        throw new Exception("Insufficient funds");
      }
      balance -= amount;

      Thread.Sleep(1000);
    }
  }

  public void Withdraw2(decimal amount)
  {
    lock (sync)
    {
      if (amount > balance)
      {
        throw new Exception("Insufficient funds");
      }
      balance -= amount;
    }
  }

  static void Main()
  {
    Lock l = new Lock();

    Console.WriteLine(l.balance);
    Console.WriteLine(l.sync);

    l.Withdraw(-5.2m);
    l.Withdraw2(-10.2m);

    Console.WriteLine(l.balance);
    Console.WriteLine(l.sync);
  }
}
