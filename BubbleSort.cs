using System;
public class BubbleSort
{
    public static void Sort(int[] arr)
    {
        bool swap = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swap = true;
                }
            }
            if (swap == false) break;
        }
    }
    public static void Main(string[] args)
    {
        int[] marks = { 90, 23, 12, 43, 86, 89, 23, 23, 53, 60, 59 };
        Sort(marks);

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write(marks[i] + " ");
        }
    }
}