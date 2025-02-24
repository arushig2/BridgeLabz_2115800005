using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("John Doe")]
class SampleClass
{
    public void Display()
    {
        Console.WriteLine("This is a sample class.");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);

        object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

        if (attributes.Length > 0)
        {
            AuthorAttribute authorAttribute = (AuthorAttribute)attributes[0];
            Console.WriteLine($"Author of {type.Name}: {authorAttribute.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }
}
