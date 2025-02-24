using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

//Create a helper class to measure execution time using Reflection
class ExecutionLogger
{
    public static void ExecuteWithLogging(object obj, string methodName)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }

        // Check if the method has the LogExecutionTime attribute
        if (method.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) != null)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();


            method.Invoke(obj, null);

            stopwatch.Stop();
            Console.WriteLine($"Execution Time for {methodName}: {stopwatch.ElapsedMilliseconds} ms");
        }
        else
        {
            // If the attribute is not applied, execute normally
            method.Invoke(obj, null);
        }
    }
}

//Apply the LogExecutionTime attribute to methods
class TestMethods
{
    [LogExecutionTime]
    public void FastMethod()
    {
        Console.WriteLine("Executing FastMethod...");
    }

    [LogExecutionTime]
    public void SlowMethod()
    {
        Console.WriteLine("Executing SlowMethod...");
        System.Threading.Thread.Sleep(2000); // Simulating delay
    }

    public void NormalMethod()
    {
        Console.WriteLine("Executing NormalMethod...");
    }
}

// Step 4: Execute methods and compare their execution times
class Program
{
    static void Main()
    {
        TestMethods test = new TestMethods();

        ExecutionLogger.ExecuteWithLogging(test, "FastMethod");
        ExecutionLogger.ExecuteWithLogging(test, "SlowMethod");
        ExecutionLogger.ExecuteWithLogging(test, "NormalMethod"); // No logging applied
    }
}
