using System;
using System.Collections.Generic;

public class FindSubset
{
    public static bool IsSubset(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.IsSubsetOf(set2);
    }

    public static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        Console.WriteLine("Enter the elements of the first set: ");
        while (true)
        {
            Console.WriteLine("Enter a number (-1 to stop): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == -1)
            {
                break;
            }
            set1.Add(n);
        }
        Console.WriteLine("Enter the elements of the second set: ");
        while (true)
        {
            Console.WriteLine("Enter a number (-1 to stop): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == -1)
            {
                break;
            }
            set2.Add(n);
        }

        Console.WriteLine(IsSubset(set1, set2));

    }
}
