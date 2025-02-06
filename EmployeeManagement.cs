//using System;

//public class Employee
//{
//    public static string companyName = "Capgemini";
//    public string name;
//    public readonly int id;
//    public string designation;
//    public static int totalEmployees = 0;


//    public Employee()
//	{
//        totalEmployees++;
//	}

//    public Employee(string name, int id, string designation)
//    {
//        this.name = name;
//        this.id = id;
//        this.designation = designation;
//        totalEmployees++;
//    }

//    public static void DisplayTotalEmployees()
//    {
//        Console.WriteLine($"Total Employees in the Company are: {totalEmployees}");
//    }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Company Name: {companyName}");
//        Console.WriteLine($"Employee Name: {name}");
//        Console.WriteLine($"Employee ID: {id}");
//        Console.WriteLine($"Designation: {designation}");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        object obj1 = new Employee("Rishi", 234, "Intern");
//        object obj2 = new Employee("Maya", 121, "HR");
//        object obj3 = "Not an Employee";

//        if (obj1 is Employee emp1)
//        {
//            emp1.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj1 is not an instance of Employee.");
//        }

//        Employee.DisplayTotalEmployees();

//        if (obj2 is Employee emp2)
//        {
//            emp2.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj2 is not an instance of Employee.");
//        }

//        Employee.DisplayTotalEmployees();

//        if (obj3 is Employee emp3)
//        {
//            emp3.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj3 is not an instance of Employee.");
//        }

//    }
//}
