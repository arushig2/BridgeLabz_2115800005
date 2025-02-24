using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class Operations
{
    [ImportantMethod] // Uses default level "HIGH"
    public void CriticalOperation()
    {
        Console.WriteLine("Executing critical operation...");
    }

    [ImportantMethod("MEDIUM")]
    public void RegularOperation()
    {
        Console.WriteLine("Executing regular operation...");
    }

    public void NormalOperation()
    {
        Console.WriteLine("Executing normal operation...");
    }
}


class Program
{
    static void Main()
    {
        Type type = typeof(Operations);
        MethodInfo[] methods = type.GetMethods();

        foreach (MethodInfo method in methods)
        {
            var attribute = (ImportantMethodAttribute)Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));

            if (attribute != null)
            {
                Console.WriteLine($"Method: {method.Name}, Importance Level: {attribute.Level}");
            }
        }
    }
}
