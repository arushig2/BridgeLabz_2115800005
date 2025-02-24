using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class SoftwareModule
{
    [BugReport("Null reference exception when input is null.")]
    [BugReport("Performance issue when handling large data sets.")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(SoftwareModule);
        MethodInfo method = type.GetMethod("ProcessData");

        if (method != null)
        {
            object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);
            foreach (BugReportAttribute attr in attributes)
            {
                Console.WriteLine($"Bug Report: {attr.Description}");
            }
        }
    }
}
