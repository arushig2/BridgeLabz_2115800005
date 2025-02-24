using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}


class ProjectModule
{
    [Todo("Implement user authentication", "Alice", "HIGH")]
    [Todo("Fix session timeout issue", "Bob", "LOW")]
    public void AuthenticationModule()
    {
        Console.WriteLine("Authentication module logic...");
    }

    [Todo("Optimize database queries", "Charlie")]
    public void DatabaseModule()
    {
        Console.WriteLine("Database optimization logic...");
    }

    public void CompletedFeature()
    {
        Console.WriteLine("This feature is already completed.");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(ProjectModule);
        MethodInfo[] methods = type.GetMethods();

        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);

            foreach (TodoAttribute attr in attributes)
            {
                Console.WriteLine($"Method: {method.Name}, Task: {attr.Task}, Assigned To: {attr.AssignedTo}, Priority: {attr.Priority}");
            }
        }
    }
}
