using System;
public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }
    public static void Main(string[] args)
    {
        int[] id = { 12, 34, 21, 55, 3, 1, 8, 13 };
        Sort(id);
        foreach (int i in id)
        {
            Console.Write(i + " ");
        }
    }
}