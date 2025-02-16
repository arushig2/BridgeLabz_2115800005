using System;
using System.Text;

public class ConcatenateStrings
{
    public static void Concat(StringBuilder[] arr)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < arr.Length; i++)
        {
            sb.Append(arr[i]);
        }
        Console.WriteLine("Concatenated string: " + sb);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of strings: ");
        int n = Convert.ToInt32(Console.ReadLine());
        StringBuilder[] arr = new StringBuilder[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter string " + (i + 1) + ": ");
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder(s);
            arr[i] = sb;
        }

        Concat(arr);

    }
}