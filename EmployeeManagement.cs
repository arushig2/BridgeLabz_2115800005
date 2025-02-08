using System;

public class Employee
{
    public string name;
    public int id;
    public double salary;

    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

public class Manager : Employee
{
    public int teamSize;

    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        this.teamSize = teamSize;
    }

    public void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + teamSize);
    }
}


public class Developer : Employee
{
    public string programmingLanguage;

    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: " + programmingLanguage);
    }
}

public class Intern : Employee
{
    public string internShipDuration;

    public Intern(string name, int id, double salary, string internShipDuration) : base(name, id, salary)
    {
        this.internShipDuration = internShipDuration;
    }

    public void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + internShipDuration);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee("John", 101, 50000);
        emp.DisplayDetails();

        Manager manager = new Manager("Mike", 102, 80000, 10);
        manager.DisplayDetails();

        Developer developer = new Developer("David", 103, 60000, "C#");
        developer.DisplayDetails();

        Intern intern = new Intern("Sam", 104, 30000, "6 months");
        intern.DisplayDetails();
    }
}
