using System;

public class CountingSort
{
    public static void Sort(int[] arr)
    {
        int[] freq = new int[9];

        for (int i = 0; i < arr.Length; i++)
        {
            freq[arr[i] - 10]++;
        }

        int k = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < freq[i]; j++)
            {
                arr[k++] = i + 10;
            }
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 12, 12, 10, 18, 17, 16, 13, 14, 13, 18, 15, 12, 16, 14, 17, 15, 11 };
        Sort(arr);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}