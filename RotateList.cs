using System;
using System.Collections.Generic;

public class Rotate
{
    public static void RotateList(List<int> list, int k)
    {
        int n = list.Count;
        list.Reverse(0, n - k);
        list.Reverse(n - k, k);
        list.Reverse();
    }

    public static void Main(string[] args)
    {
        List<int> list = new List<int>();

        while (true)
        {
            Console.WriteLine("Enter a number (-1 to stop): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == -1)
            {
                break;
            }
            list.Add(n);
        }

        Console.WriteLine("Enter the number of rotations: ");
        int k = Convert.ToInt32(Console.ReadLine());

        k = k % list.Count;

        RotateList(list, k);

        foreach (int i in list)
        {
            Console.Write(i + " ");
        }
    }
}

