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
        Student student = new Student
        {
            Name = "John Doe",
            Age = 20,
            Subjects = new List<string> { "Math", "Physics", "Computer Science" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(json);
    }
}
