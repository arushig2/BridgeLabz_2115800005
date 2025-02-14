using System;

public class QuickSort
{
    public static int Partition(int[] arr, int l, int r)
    {
        int pivot = arr[r];
        int i = l - 1;
        for (int j = l; j < r; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[r];
        arr[r] = temp1;
        return i + 1;
    }
    public static void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int pivot = Partition(arr, l, r);
            Sort(arr, l, pivot - 1);
            Sort(arr, pivot + 1, r);
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = { 12, 34, 21, 55, 3, 1, 8, 13 };
        int n = arr.Length;
        Sort(arr, 0, n - 1);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}