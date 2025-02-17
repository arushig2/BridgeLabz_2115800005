using System;
using System.Diagnostics;

class CompareSearchAlgo
{
    public static bool LinearSearch(int[] arr, int key)
    {
        foreach (int n in arr)
        {
            if (n == key)
            {
                return true;
            }
        }
        return false;
    }

    public static bool BinarySearch(int[] arr, int key)
    {
        int l = 0;
        int r = arr.Length - 1;

        while (l <= r)
        {
            int mid = (l + r) / 2;

            if (arr[mid] == key)
            {
                return true;
            }
            else if (arr[mid] > key)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        int[] sizes = { 1000, 10000, 1000000 };
        Random random = new Random();

        foreach (int size in sizes)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }

            int key = arr[random.Next(size)];

            Console.WriteLine($"Array Size: {size}");

            Stopwatch sw = Stopwatch.StartNew();
            bool foundLinear = LinearSearch(arr, key);
            sw.Stop();
            Console.WriteLine($"Linear Search Time: {sw.Elapsed.TotalMilliseconds} ms");


            Array.Sort(arr);


            sw.Restart();
            bool foundBinary = BinarySearch(arr, key);
            sw.Stop();
            Console.WriteLine($"Binary Search Time: {sw.Elapsed.TotalMilliseconds} ms");


        }
    }
}
