using System;
using System.Collections.Generic;

public class SortSet
{
    public static List<int> SetToList(HashSet<int> set)
    {
        List<int> list = new List<int>(set);
        list.Sort();
        return list;
    }

    public static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();
        Console.WriteLine("Enter the elements of the set: ");
        while (true)
        {
            Console.WriteLine("Enter a number (-1 to stop): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == -1)
            {
                break;
            }
            set.Add(n);
        }
        List<int> list = SetToList(set);
        foreach (int i in list)
        {
            Console.Write(i + " ");
        }
    }
}