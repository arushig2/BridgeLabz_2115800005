using System;
using System.Collections.Generic;

class Reverse
{
    public static void ReverseQueue(Queue<int> queue)
    {
        if (queue.Count == 0)
            return;

        int front = queue.Dequeue();

        ReverseQueue(queue);

        queue.Enqueue(front);
    }

    public static void Main()
    {

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        ReverseQueue(queue);

        Console.WriteLine(string.Join(", ", queue));
    }

}
