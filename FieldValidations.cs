using System;
using System.Reflection;

// Define the MaxLength attribute
[AttributeUsage(AttributeTargets.Property)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

class User
{
    [MaxLength(10)]
    public string Username { get; }

    public User(string username)
    {
        // Validate max length using Reflection
        PropertyInfo prop = typeof(User).GetProperty(nameof(Username));
        var attribute = (MaxLengthAttribute)Attribute.GetCustomAttribute(prop, typeof(MaxLengthAttribute));

        if (attribute != null && username.Length > attribute.Length)
        {
            throw new ArgumentException($"Username exceeds max length of {attribute.Length} characters.");
        }

        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User validUser = new User("JohnDoe");
            Console.WriteLine($"User created: {validUser.Username}");

            User invalidUser = new User("VeryLongUsername");
            Console.WriteLine($"User created: {invalidUser.Username}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
