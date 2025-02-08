using System;
using System.Security.Cryptography.X509Certificates;

public class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void DisplayRole()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

public class Teacher : Person
{
    public string subject;

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        this.subject = subject;
    }

    public void DisplayRole()
    {
        Console.WriteLine("Teacher Details: ");
        base.DisplayRole();
        Console.WriteLine("Subject: " + subject);
    }
}

public class Student : Person
{
    public int grade;
    public Student(string name, int age, int grade) : base(name, age)
    {
        this.grade = grade;
    }
    public void DisplayRole()
    {
        Console.WriteLine("Student Details: ");
        base.DisplayRole();
        Console.WriteLine("Grade: " + grade);
    }
}

public class Staff : Person
{
    public string role;

    public Staff(string name, int age, string role) : base(name, age)
    {
        this.role = role;
    }
    public void DisplayRole()
    {
        Console.WriteLine("Staff Details: ");
        base.DisplayRole();
        Console.WriteLine("Role: " + role);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher("John", 35, "Maths");
        teacher.DisplayRole();

        Console.WriteLine();

        Student student = new Student("Alice", 15, 10);
        student.DisplayRole();

        Console.WriteLine();

        Staff staff = new Staff("Bob", 25, "Librarian");
        staff.DisplayRole();
    }
}