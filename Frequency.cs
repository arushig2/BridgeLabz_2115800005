using System;
using System.Collections.Generic;

public class Frequency
{
    public static void FindFreq(List<string> list, Dictionary<string, int> freqs)
    {
        foreach (var item in list)
        {
            if (freqs.ContainsKey(item))
            {
                freqs[item]++;
            }
            else
            {
                freqs[item] = 1;
            }
        }
    }

    public static void Main(String[] args)
    {
        List<string> list = new List<string>();

        list.Add("apple");
        list.Add("banana");
        list.Add("apple");
        list.Add("apple");
        list.Add("banana");
        list.Add("cherry");

        Dictionary<string, int> freqs = new Dictionary<string, int>();

        FindFreq(list, freqs);

        foreach (var item in freqs)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
