using System;

public class RemoveDuplicates
{
    public static void RemoveDupes(List<int> list)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (set.Contains(list[i]))
            {
                list.RemoveAt(i);
                i--;
            }
            else
            {
                set.Add(list[i]);
            }
        }
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
        RemoveDupes(list);
        foreach (int i in list)
        {
            Console.Write(i + " ");
        }
    }
}