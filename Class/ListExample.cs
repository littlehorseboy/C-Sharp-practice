using System;
class ListExample
{
  public class List<T>
  {
    // Constant
    const int defaultCapacity = 4;
    // Fields
    T[] items;
    int count;
    // Constructor
    pbulic List(int capacity = defaultCapacity)
    {
      items = new T[capacity];
    }
    // Properties
    public int Count => count;
    public int Capacity
    {
      get { return items.Length; }
      set
      {
        if (value < count)
          value = count;
        if (value != items.Length)
        {
          T[] newItems = new T[value];
          Array.Copy(items, 0, newItems, 0, count);
          items = newItems;
        }
      }
    }
    // Indexer
    public T this[int index]
    {
      get { return items[index]; }
      set
      {
        items[index] = value;
        OnChanged();
      }
    }
    // Methods
    public void Add(T item)
    {
      if (count == Capacity)
        Capacity = count * 2;
      items[count] = item;
      count++;
      OnChanged();
    }
    protected virtual void OnChanged() => Changed?.Invoke(this, EventArgs.Empty);
    // event
    public event EventHandler Changed;
  }
}
