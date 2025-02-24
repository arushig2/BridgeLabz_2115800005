using System;
using System.Reflection;

class Person
{
    private int age = 25;

    public void DisplayAge()
    {
        Console.WriteLine($"Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);

        FieldInfo fieldInfo = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        if (fieldInfo != null)
        {

            int originalAge = (int)fieldInfo.GetValue(person);
            Console.WriteLine($"Original Age: {originalAge}");

            fieldInfo.SetValue(person, 30);

            int updatedAge = (int)fieldInfo.GetValue(person);
            Console.WriteLine($"Updated Age: {updatedAge}");

            person.DisplayAge();
        }
        else
        {
            Console.WriteLine("Field 'age' not found.");
        }
    }
}
