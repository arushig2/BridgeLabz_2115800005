using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 8, -5, 10, -2, 4 };
        int firstNegative = LinearSearchFirstNegative(numbers);

        if (firstNegative != int.MaxValue)
        {
            Console.WriteLine("First negative number found: " + firstNegative);
        }
        else
        {
            Console.WriteLine("No negative number found in the array.");
        }
    }

    static int LinearSearchFirstNegative(int[] arr)
    {
        foreach (int num in arr)
        {
            if (num < 0)
            {
                return num;
            }
        }
        return int.MaxValue;
    }
}
