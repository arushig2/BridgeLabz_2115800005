using System;
using System.Collections.Generic;

public interface IDepartment
{
    public void AssignDepartment(string departmnetName);
    public void GetDepartmentDetails();
}

public abstract class Emplopyee : IDepartment
{
    private string employeeID;
    private string name;
    private double baseSalary;
    private string departmentName;

    public string EmployeeID
    {
        get { return employeeID; }
        set { employeeID = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    public Emplopyee(string employeeID, string name, double baseSalary)
    {
        this.employeeID = employeeID;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public abstract void CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Base Salary: " + baseSalary);
    }

    public void AssignDepartment(string departmnetName)
    {
        this.departmentName = departmnetName;

    }

    public void GetDepartmentDetails()
    {
        Console.WriteLine("Department Details: " + departmentName);
    }
}

class FullTimeEmployee : Emplopyee
{
    private double fixedSalary;

    public double FixedSalary
    {
        get { return fixedSalary; }
        set { fixedSalary = value; }
    }

    public FullTimeEmployee(string employeeID, string name, double baseSalary, double fixedSalary) : base(employeeID, name, baseSalary)
    {
        this.fixedSalary = fixedSalary;
    }

    public override void CalculateSalary()
    {
        double baseSalary = BaseSalary;
        double salary = baseSalary + fixedSalary;
        Console.WriteLine("Full Time Employee Salary: " + salary);
    }
}

class PartTimeEmployee : Emplopyee
{
    private int workingHours;
    private double hourlyRate;

    public int WorkingHours
    {
        get { return workingHours; }
        set { workingHours = value; }
    }

    public double HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public PartTimeEmployee(string employeeID, string name, double baseSalary, int workingHours, double hourlyRate) : base(employeeID, name, baseSalary)
    {
        this.workingHours = workingHours;
        this.hourlyRate = hourlyRate;
    }

    public override void CalculateSalary()
    {
        double baseSalary = BaseSalary;
        double salary = baseSalary + (workingHours * hourlyRate);
        Console.WriteLine("Part Time Employee Salary: " + salary);
    }
}

public class Program
{
    public static void Main()
    {

        List<Emplopyee> emplopyees = new List<Emplopyee>();

        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("FTE001", "John", 50000, 10000);
        fullTimeEmployee.AssignDepartment("IT");

        PartTimeEmployee partTimeEmployee = new PartTimeEmployee("PTE001", "Smith", 20000, 40, 500);
        partTimeEmployee.AssignDepartment("HR");

        emplopyees.Add(fullTimeEmployee);
        emplopyees.Add(partTimeEmployee);

        foreach (Emplopyee emplopyee in emplopyees)
        {
            emplopyee.DisplayDetails();
            emplopyee.GetDepartmentDetails();
            emplopyee.CalculateSalary();
            Console.WriteLine();
        }

    }
}

