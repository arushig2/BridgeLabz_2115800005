using System;

public class HeapSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }
        for (int i = n - 1; i > 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            Heapify(arr, i, 0);
        }
    }
    public static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int l = 2 * i + 1;
        int r = 2 * i + 2;
        if (l < n && arr[l] > arr[largest])
        {
            largest = l;
        }
        if (r < n && arr[r] > arr[largest])
        {
            largest = r;
        }
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
            Heapify(arr, n, largest);
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = { 12, 34, 21, 55, 3, 1, 8, 13 };

        Sort(arr);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}