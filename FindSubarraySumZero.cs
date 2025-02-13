using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static List<(int, int)> FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> prefixSumMap = new Dictionary<int, List<int>>();
        List<(int, int)> result = new List<(int, int)>();

        int cumulativeSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            cumulativeSum += arr[i];

            // If sum is zero, add subarray from 0 to i
            if (cumulativeSum == 0)
            {
                result.Add((0, i));
            }

            // If sum has been seen before, add all subarrays
            if (prefixSumMap.ContainsKey(cumulativeSum))
            {
                foreach (int startIndex in prefixSumMap[cumulativeSum])
                {
                    result.Add((startIndex + 1, i));
                }
            }

            // Store the index in the prefix sum map
            if (!prefixSumMap.ContainsKey(cumulativeSum))
            {
                prefixSumMap[cumulativeSum] = new List<int>();
            }
            prefixSumMap[cumulativeSum].Add(i);
        }

        return result;
    }

    public static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, -4, -2, -2 };
        List<(int, int)> subarrays = FindZeroSumSubarrays(arr);

        Console.WriteLine("Zero-sum subarrays:");
        foreach (var (start, end) in subarrays)
        {
            Console.WriteLine($"[{start}, {end}]");
        }
    }
}
