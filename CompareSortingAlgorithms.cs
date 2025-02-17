using System;
using System.Diagnostics;

class CompareSortingAlgorithms
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    private static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                arr[k++] = left[i++];
            else
                arr[k++] = right[j++];
        }
        while (i < left.Length)
            arr[k++] = left[i++];
        while (j < right.Length)
            arr[k++] = right[j++];
    }

    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    public static void Main(string[] args)
    {
        int[] sizes = { 1000, 10000, 1000000 };
        Random random = new Random();

        foreach (int size in sizes)
        {
            int[] originalArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                originalArray[i] = random.Next(size);
            }

            Console.WriteLine($"Array Size: {size}");

            if (size <= 10000)
            {
                int[] arr = (int[])originalArray.Clone();
                Stopwatch sw = Stopwatch.StartNew();
                BubbleSort(arr);
                sw.Stop();
                Console.WriteLine($"Bubble Sort Time: {sw.Elapsed.TotalMilliseconds} ms");
            }
            else
            {
                Console.WriteLine("Bubble Sort: Skipped (Too Slow)");
            }

            int[] mergeArr = (int[])originalArray.Clone();
            Stopwatch swMerge = Stopwatch.StartNew();
            MergeSort(mergeArr);
            swMerge.Stop();
            Console.WriteLine($"Merge Sort Time: {swMerge.Elapsed.TotalMilliseconds} ms");

            int[] quickArr = (int[])originalArray.Clone();
            Stopwatch swQuick = Stopwatch.StartNew();
            QuickSort(quickArr, 0, quickArr.Length - 1);
            swQuick.Stop();
            Console.WriteLine($"Quick Sort Time: {swQuick.Elapsed.TotalMilliseconds} ms");
        }
    }
}
