using System;
using System.Collections.Generic;

class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

            if (!numIndices.ContainsKey(nums[i]))  
            {
                numIndices[nums[i]] = i;
            }
        }

        return new int[] { };  
    }

    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);
        if (result.Length > 0)
        {
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("No valid pair found.");
        }
    }
}
