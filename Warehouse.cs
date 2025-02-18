using System;

public abstract class WarehouseItem
{
    public string name;

    public WarehouseItem(string name)
    {
        this.name = name;
    }

    public abstract void Display();
}

public class Electronics : WarehouseItem
{
    public Electronics(string name) : base(name)
    {
    }
    public override void Display()
    {
        Console.WriteLine("Electronics: " + name);
    }
}

public class Groceries : WarehouseItem
{
    public Groceries(string name) : base(name)
    {
    }
    public override void Display()
    {
        Console.WriteLine("Groceries: " + name);
    }
}

public class Furniture : WarehouseItem
{
    public Furniture(string name) : base(name)
    {
    }
    public override void Display()
    {
        Console.WriteLine("Furniture: " + name);
    }

}

public class Storage<T> where T : WarehouseItem
{
    List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public void Remove(T item)
    {
        list.Remove(item);
    }

    public void Display()
    {
        foreach (T item in list)
        {
            item.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        Storage<WarehouseItem> storage = new Storage<WarehouseItem>();
        storage.Add(new Electronics("TV"));
        storage.Add(new Groceries("Milk"));
        storage.Add(new Furniture("Table"));
        storage.Display();
    }
}