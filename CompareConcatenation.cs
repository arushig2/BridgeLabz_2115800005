using System;
using System.Diagnostics;
using System.Text;

class StringConcatenationComparison
{
    public static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int size in sizes)
        {
            Console.WriteLine($"Operations Count: {size}");

            Stopwatch sw = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < size; i++)
            {
                str += "a";
            }
            sw.Stop();
            Console.WriteLine($"String Concatenation Time: {sw.Elapsed.TotalMilliseconds} ms");

            Stopwatch swBuilder = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                sb.Append("a");
            }
            swBuilder.Stop();
            Console.WriteLine($"StringBuilder Time: {swBuilder.Elapsed.TotalMilliseconds} ms");


        }
    }
}
