using System;
using System.Collections.Generic;
public class Employee
{
   public string Name;
   public int Id;

   public Employee(string name, int id)
   {
       Name = name;
       Id = id;
   }

   public void ShowEmployeeInfo()
   {
       Console.WriteLine($"\tEmployee ID: {Id}, Name: {Name}");
   }
}
public class Department
{
   public string DepartmentName;
   public List<Employee> Employees;

   public Department(string departmentName)
   {
       DepartmentName = departmentName;
       Employees = new List<Employee>();
   }

   public void AddEmployee(Employee employee)
   {
       Employees.Add(employee);
   }

   public void ShowDepartmentInfo()
   {
       Console.WriteLine($"Department: {DepartmentName}");
       if (Employees.Count == 0)
       {
           Console.WriteLine("\tNo employees in this department.");
       }
       else
       {
           foreach (var employee in Employees)
           {
               employee.ShowEmployeeInfo();
           }
       }
   }
}
public class Company : IDisposable
{
   public string CompanyName;
   public List<Department> Departments;

   public Company(string companyName)
   {
       CompanyName = companyName;
       Departments = new List<Department>();
   }

   public void AddDepartment(Department department)
   {
       Departments.Add(department);
   }

   public void DisplayCompanyInfo()
   {
       Console.WriteLine($"Company Name: {CompanyName}");
       if (Departments.Count == 0)
       {
           Console.WriteLine("No departments in the company.");
       }
       else
       {
           foreach (var department in Departments)
           {
               department.ShowDepartmentInfo();
           }
       }
   }

   public void Dispose()
   {
       foreach (var department in Departments)
       {
           department.Employees.Clear();
       }
       Departments.Clear();
       Console.WriteLine("Company and all its departments and employees have been deleted.");
   }
}

class Program
{
   static void Main(string[] args)
   {
       Company company = new Company("TechCorp");

       Department hr = new Department("HR");
       hr.AddEmployee(new Employee("Alice", 1));
       hr.AddEmployee(new Employee("Bob", 2));

       Department it = new Department("IT");
       it.AddEmployee(new Employee("Charlie", 3));
       it.AddEmployee(new Employee("Dave", 4));

       company.AddDepartment(hr);
       company.AddDepartment(it);

       company.DisplayCompanyInfo();

       Console.WriteLine("\nDisposing company...\n");
       company.Dispose();
   }
}
