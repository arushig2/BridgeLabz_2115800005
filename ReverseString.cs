using System;
using System.Text;

public class ReverseString
{
    public static void Reverse(StringBuilder sb)
    {
        for (int i = 0; i < sb.Length / 2; i++)
        {
            char temp = sb[i];
            sb[i] = sb[sb.Length - i - 1];
            sb[sb.Length - i - 1] = temp;
        }

    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        StringBuilder sb = new StringBuilder(str);
        Reverse(sb);

        Console.WriteLine("Reversed string: " + sb);

    }
}