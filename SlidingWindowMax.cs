using System;

public class Node
{
    public int value;
    public Node next;

    public Node(int value)
    {
        this.value = value;
    }
}

public class Dequeue
{
    public Node head;
    public Node tail;

    public void AddFront(int value)
    {
        if (head == null)
        {
            head = new Node(value);
            tail = head;
        }
        else
        {
            Node temp = new Node(value);
            temp.next = head;
            head = temp;
        }

    }

    public void AddBack(int value)
    {
        if (tail == null)
        {
            tail = new Node(value);
            head = tail;
        }
        else
        {
            Node temp = new Node(value);
            tail.next = temp;
            tail = temp;
        }
    }

    public int Front()
    {
        return head.value;
    }

    public int Back()
    {
        return tail.value;
    }

    public void PopFront()
    {
        if (head != null)
        {
            head = head.next;
        }
        else
        {
            Console.WriteLine("Queue is already empty");
        }
    }

    public void PopBack()
    {
        if (head == tail)
        {
            head = tail = null;
            return;
        }

        if (tail != null)
        {
            Node temp = head;

            while (temp.next != tail)
            {
                temp = temp.next;
            }

            temp.next = null;
            tail = temp;
        }
    }

    public bool IsEmpty()
    {
        return head == null;
    }
}
public class Program
{

    public static List<int> SlidingWindowMax(int[] arr, int k)
    {
        Dequeue dq = new Dequeue();
        List<int> ans = new List<int>();

        for (int i = 0; i < k; i++)
        {
            while (!dq.IsEmpty() && arr[dq.Back()] < arr[i])
            {
                dq.PopBack();
            }
            dq.AddBack(i);
        }

        ans.Add(arr[dq.Front()]);

        for (int i = k; i < arr.Length; i++)
        {
            while (!dq.IsEmpty() && dq.Front() < i - k + 1)
            {
                dq.PopFront();
            }

            while (!dq.IsEmpty() && arr[dq.Back()] < arr[i])
            {
                dq.PopBack();
            }

            dq.AddBack(i);

            ans.Add(arr[dq.Front()]);
        }

        return ans;

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of element: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter Size of Window: ");
        int k = Convert.ToInt32(Console.ReadLine());

        List<int> ans = SlidingWindowMax(arr, k);

        foreach (int num in ans)
        {
            Console.Write(num + " ");
        }
    }
}
