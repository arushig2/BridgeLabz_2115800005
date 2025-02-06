using System;
using System.Collections.Generic;

public class Faculty
{
   public string Name;

   public Faculty(string name)
   {
       Name = name;
   }

   public void ShowFacultyInfo()
   {
       Console.WriteLine($"\tFaculty: {Name}");
   }
}

public class Department
{
   public string Name;
   public List<Faculty> Faculties;

   public Department(string name)
   {
       Name = name;
       Faculties = new List<Faculty>();
   }

   public void AddFaculty(Faculty faculty)
   {
       Faculties.Add(faculty);
   }

   public void ShowDepartmentInfo()
   {
       Console.WriteLine($"Department: {Name}");
       if (Faculties.Count == 0)
       {
           Console.WriteLine("\tNo faculties in this department.");
       }
       else
       {
           foreach (var faculty in Faculties)
           {
               faculty.ShowFacultyInfo();
           }
       }
   }
}

public class University
{
   public string Name;
   public List<Department> Departments;

   public University(string name)
   {
       Name = name;
       Departments = new List<Department>();
   }

   public void AddDepartment(Department department)
   {
       Departments.Add(department);
   }

   public void DisplayUniversityInfo()
   {
       Console.WriteLine($"University: {Name}");
       if (Departments.Count == 0)
       {
           Console.WriteLine("No departments in this university.");
       }
       else
       {
           foreach (var department in Departments)
           {
               department.ShowDepartmentInfo();
           }
       }
   }

   ~University()
   {
      
       Departments.Clear();
       Console.WriteLine("University and its departments are deleted.");
   }
}

public class Program
{
   public static void Main(string[] args)
   {
       Faculty faculty1 = new Faculty("Dr. Smith");
       Faculty faculty2 = new Faculty("Dr. Johnson");

        
       Department csDepartment = new Department("Computer Science");
       csDepartment.AddFaculty(faculty1);

       Department mathDepartment = new Department("Mathematics");
       mathDepartment.AddFaculty(faculty2);

       University university = new University("Tech University");
       university.AddDepartment(csDepartment);
       university.AddDepartment(mathDepartment);

       university.DisplayUniversityInfo();

       Faculty independentFaculty = new Faculty("Dr. Brown");
       Console.WriteLine($"\n{independentFaculty.Name} exists independently of any department.\n");

     
       Console.WriteLine("\nDeleting university...\n");
       university = null;
       GC.Collect();
       GC.WaitForPendingFinalizers();
   }
}
