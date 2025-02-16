using System;
using System.Text;

public class RemoveDuplicates
{
    public static void RemoveDuplicate(StringBuilder sb)
    {
        for (int i = 0; i < sb.Length; i++)
        {
            for (int j = i + 1; j < sb.Length; j++)
            {
                if (sb[i] == sb[j])
                {
                    sb.Remove(j, 1);
                    j--;
                }
            }
        }
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        StringBuilder sb = new StringBuilder(str);

        RemoveDuplicate(sb);

        Console.WriteLine("String after removing duplicates: " + sb);
    }
}