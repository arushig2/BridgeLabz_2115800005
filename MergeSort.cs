using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class MergeSort
{

    public static void Merge(int[] arr, int l, int mid, int r)
    {
        List<int> temp = new List<int>();
        int i = l, j = mid + 1;

        while (i <= mid && j <= r)
        {
            if (arr[i] < arr[j])
            {
                temp.Add(arr[i]);
                i++;
            }
            else
            {
                temp.Add(arr[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            temp.Add(arr[i++]);
        }

        while (j <= r)
        {
            temp.Add(arr[j++]);
        }

        for (int k = l; k <= r; k++)
        {
            arr[k] = temp[k - l];
        }
    }
    public static void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int mid = (l + r) / 2;
            Sort(arr, l, mid);
            Sort(arr, mid + 1, r);
            Merge(arr, l, mid, r);
        }
    }
    public static void Main(string[] args)
    {
        int[] price = { 250, 872, 123, 765, 321, 654, 987, 456, 789 };
        int n = price.Length;

        Sort(price, 0, n - 1);

        foreach (int i in price)
        {
            Console.Write(i + " ");
        }
    }
}