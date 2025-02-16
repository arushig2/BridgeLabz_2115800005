using System;

class Program
{
    static void Main()
    {
        int[] nums = { 3, 4, -1, 1, 7, 8, 10 };
        int target = 8;

        int missingPositive = FindFirstMissingPositive(nums);
        Console.WriteLine("First missing positive integer: " + missingPositive);

        Array.Sort(nums);
        int targetIndex = BinarySearch(nums, target);
        Console.WriteLine("Index of target " + target + ": " + targetIndex);
    }

    static int FindFirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
            {
                int temp = nums[i];
                nums[i] = nums[temp - 1];
                nums[temp - 1] = temp;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }
        return n + 1;
    }

    static int BinarySearch(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}