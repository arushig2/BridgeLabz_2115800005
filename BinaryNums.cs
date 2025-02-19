using System;
using System.Collections.Generic;

class BinaryNumbers
{
    public static List<string> GenerateBinaryNumbers(int N)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("1");

        for (int i = 0; i < N; i++)
        {
            string front = queue.Dequeue();
            result.Add(front);

            queue.Enqueue(front + "0");
            queue.Enqueue(front + "1");
        }

        return result;
    }

    public static void Main()
    {
        int N = 10;
        List<string> binaryNumbers = GenerateBinaryNumbers(N);

        Console.WriteLine(string.Join(", ", binaryNumbers));
    }

}
