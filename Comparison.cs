using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int iterations = 100000;

        // Using String Concatenation
        Stopwatch stopwatch = Stopwatch.StartNew();
        string str = "";
        for (int i = 0; i < iterations; i++)
        {
            str += "a";
        }
        stopwatch.Stop();
        Console.WriteLine("Time taken using String concatenation: " + stopwatch.ElapsedMilliseconds + " ms");

        // Using StringBuilder
        stopwatch.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
        }
        stopwatch.Stop();
        Console.WriteLine("Time taken using StringBuilder: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
