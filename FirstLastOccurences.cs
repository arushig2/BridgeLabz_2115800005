using System;

class Program
{
    static void Main()
    {
        int[] nums = { 5, 7, 7, 8, 8, 10 };
        int target = 8;
        int firstOccurrence = FindFirstOccurrence(nums, target);
        int lastOccurrence = FindLastOccurrence(nums, target);

        Console.WriteLine("First occurrence of " + target + ": " + firstOccurrence);
        Console.WriteLine("Last occurrence of " + target + ": " + lastOccurrence);
    }

    static int FindFirstOccurrence(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                result = mid;
                right = mid - 1; // Move left to find the first occurrence
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }

    static int FindLastOccurrence(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                result = mid;
                left = mid + 1; 
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }
}