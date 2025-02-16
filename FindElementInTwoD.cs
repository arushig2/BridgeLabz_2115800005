﻿using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };
        int target = 16;
        bool found = SearchMatrix(matrix, target);

        Console.WriteLine("Target " + target + (found ? " found in the matrix." : " not found in the matrix."));
    }

    static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int left = 0, right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols, mid % cols];

            if (midValue == target)
                return true;
            else if (midValue < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
}
