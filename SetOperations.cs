using System;
using System.Collections.Generic;
public class SetOps
{
    public static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);
        return union;
    }

    public static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        return intersection;
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

        HashSet<int> union = Union(set1, set2);
        HashSet<int> intersection = Intersection(set1, set2);

        Console.WriteLine("Union: ");

        foreach (int i in union)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nIntersection: ");

        foreach (int i in intersection)
        {
            Console.Write(i + " ");
        }
    }
}