using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        MathOperations mathOps = new MathOperations();
        Type type = typeof(MathOperations);

        Console.WriteLine("Available Methods: Add, Subtract, Multiply");
        Console.Write("Enter method name to invoke: ");
        string methodName = Console.ReadLine();

        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        MethodInfo methodInfo = type.GetMethod(methodName);

        if (methodInfo != null)
        {
            object result = methodInfo.Invoke(mathOps, new object[] { num1, num2 });
            Console.WriteLine($"Result of {methodName}({num1}, {num2}): {result}");
        }
        else
        {
            Console.WriteLine("Invalid method name.");
        }
    }
}
