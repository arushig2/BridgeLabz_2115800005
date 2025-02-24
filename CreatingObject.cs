using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }

    public Student()
    {
        Name = "Default Student";
    }

    public void Display()
    {
        Console.WriteLine($"Student Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);

        object studentInstance = Activator.CreateInstance(type);

        if (studentInstance != null)
        {
            Console.WriteLine("Student object created dynamically!");

            MethodInfo methodInfo = type.GetMethod("Display");
            methodInfo?.Invoke(studentInstance, null);
        }
        else
        {
            Console.WriteLine("Failed to create Student object.");
        }
    }
}
