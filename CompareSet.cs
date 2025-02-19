using System;
using System.Collections.Generic;

public class CompareSet
{
    public static bool AreSetEqual(HashSet<int> set1, HashSet<int> set2)
    {
        if (set1.Count != set2.Count)
        {
            return false;
        }
        foreach (int i in set1)
        {
            if (!set2.Contains(i))
            {
                return false;
            }
        }
        return true;
    }
    public static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>();

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

        HashSet<int> set2 = new HashSet<int>();

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

        Console.WriteLine(AreSetEqual(set1, set2));
    }
}
