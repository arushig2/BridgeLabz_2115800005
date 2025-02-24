using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.Write("Enter the fully qualified class name (e.g., System.String): ");
        string className = Console.ReadLine();

        try
        {
            Type type = Type.GetType(className);

            if (type == null)
            {
                Console.WriteLine("Class not found. Ensure you provide the correct fully qualified name.");
                return;
            }

            Console.WriteLine($"\nClass: {type.FullName}");


            Console.WriteLine("\nFields:");
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");
            }

            Console.WriteLine("\nMethods:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"{method.ReturnType} {method.Name}()");
            }


            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
