using System;

public class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    public double GetSalary()
    {
        return salary;
    }

    public void SetSalary(double newSalary)
    {
        if (newSalary >= 0)
        {
            salary = newSalary;
        }
        else
        {
            Console.WriteLine("Salary cannot be negative.");
        }
    }

    public Employee() { }

    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Employee ID: {employeeID}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Salary: {GetSalary()}"); // Access salary via method
    }
}

public class Manager : Employee
{
    public string teamName;

    public Manager(int employeeID, string department, double salary, string teamName)
        : base(employeeID, department, salary)
    {
        this.teamName = teamName;
    }
    public void DisplayManagerInfo()
    {
        Console.WriteLine("Manager Details:");
        Console.WriteLine($"Employee ID: {employeeID}"); 
        Console.WriteLine($"Department: {department}"); 
        Console.WriteLine($"Salary: {GetSalary()}"); // Private member (Accessed via method)
        Console.WriteLine($"Team Name: {teamName}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
  
        Employee emp1 = new Employee(101, "HR", 50000);
        emp1.DisplayEmployeeDetails();
        emp1.SetSalary(55000);
        emp1.DisplayEmployeeDetails();
        Console.WriteLine($"Updated Salary (via method): {emp1.GetSalary()}");


        Manager mgr1 = new Manager(102, "IT", 80000, "Software Development");
        mgr1.DisplayManagerInfo(); 

        mgr1.SetSalary(85000);
        mgr1.DisplayEmployeeDetails(); 
        Console.WriteLine($"Updated Salary: {mgr1.GetSalary()}");
    }
}
