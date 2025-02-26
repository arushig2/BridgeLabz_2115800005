using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Subjects { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 22, Subjects = new List<string> { "Math", "Physics" } },
            new Student { Name = "Bob", Age = 24, Subjects = new List<string> { "Computer Science", "AI" } }
        };

        string json = JsonConvert.SerializeObject(students, Formatting.Indented);
        Console.WriteLine(json);
    }
}
