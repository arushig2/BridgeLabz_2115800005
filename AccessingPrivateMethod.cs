using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo methodInfo = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (methodInfo != null)
        {

            object result = methodInfo.Invoke(calculator, new object[] { 5, 6 });

            Console.WriteLine($"Result of Multiply(5, 6): {result}");
        }
        else
        {
            Console.WriteLine("Method 'Multiply' not found.");
        }
    }
}
