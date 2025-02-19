using System;

public class SymmetricDiff
{
    public static void SymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>(set1);
        result.SymmetricExceptWith(set2);
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
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
        SymmetricDifference(set1, set2);
    }
}
