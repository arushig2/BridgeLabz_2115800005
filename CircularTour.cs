using System;
using System.Collections.Generic;

class CircularTour
{
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        Queue<int> queue = new Queue<int>();
        int currentSurplus = 0, totalSurplus = 0, startIndex = 0;

        for (int i = 0; i < n; i++)
        {
            int surplus = petrol[i] - distance[i];
            totalSurplus += surplus;
            currentSurplus += surplus;
            queue.Enqueue(i);

            // If surplus becomes negative, remove elements from queue
            while (currentSurplus < 0 && queue.Count > 0)
            {
                int removedIndex = queue.Dequeue();
                currentSurplus -= petrol[removedIndex] - distance[removedIndex];
                startIndex = removedIndex + 1;
            }
        }

        return (totalSurplus >= 0) ? startIndex : -1;
    }

    public static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int start = FindStartingPump(petrol, distance);
        Console.WriteLine("Starting Pump Index: " + start);
    }
}
