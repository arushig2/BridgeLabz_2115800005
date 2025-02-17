using System;
using System.Diagnostics;

class FibonacciComparison
{
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    public static void Main()
    {
        int[] testValues = { 10, 30, 50 };

        foreach (int n in testValues)
        {
            Console.WriteLine($"Fibonacci({n}):");

            if (n <= 30)
            {
                Stopwatch swRec = Stopwatch.StartNew();
                int fibRec = FibonacciRecursive(n);
                swRec.Stop();
                Console.WriteLine($"Recursive Result: {fibRec}, Time: {swRec.Elapsed.TotalMilliseconds} ms");
            }
            else
            {
                Console.WriteLine("Recursive: Unfeasible (Too slow)");
            }

            Stopwatch swIter = Stopwatch.StartNew();
            int fibIter = FibonacciIterative(n);
            swIter.Stop();
            Console.WriteLine($"Iterative Result: {fibIter}, Time: {swIter.Elapsed.TotalMilliseconds} ms");

        }
    }
}
