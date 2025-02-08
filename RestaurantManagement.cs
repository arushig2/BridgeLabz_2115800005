using System;

public interface IWorker
{
    void PerformDuties();
}
public class Person
{
    public string name;
    public int id;

    public Person(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public void DisplayRole()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
    }
}

public class Chef : Person, IWorker
{
    public string cuisine;
    public Chef(string name, int id, string cuisine) : base(name, id)
    {
        this.cuisine = cuisine;
    }

    public void PerformDuties()
    {
        Console.WriteLine("Chef is cooking");
    }

    public void DisplayRole()
    {
        Console.WriteLine("Chef Details: ");
        base.DisplayRole();
        Console.WriteLine("Cuisine: " + cuisine);
    }
}

public class Waiter : Person, IWorker
{
    public string restaurant;

    public Waiter(string name, int id, string restaurant) : base(name, id)
    {
        this.restaurant = restaurant;
    }

    public void PerformDuties()
    {
        Console.WriteLine("Waiter is serving food");
    }

    public void DisplayRole()
    {
        Console.WriteLine("Waiter Details: ");
        base.DisplayRole();
        Console.WriteLine("Restaurant: " + restaurant);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Chef chef = new Chef("John", 1, "Italian");
        chef.DisplayRole();
        chef.PerformDuties();

        Console.WriteLine();

        Waiter waiter = new Waiter("Alice", 2, "Pasta Palace");
        waiter.DisplayRole();
        waiter.PerformDuties();
    }
}
