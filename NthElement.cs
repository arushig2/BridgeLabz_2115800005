using System;
using System.Collections.Generic;
public class NthElement
{
    public static char FindNthElement(LinkedList<char> list, int n)
    {
        LinkedListNode<char> slow = list.First;
        LinkedListNode<char> fast = list.First;

        for (int i = 0; i < n; i++)
        {
            fast = fast.Next;
        }

        while (fast != null)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        return slow.Value;


    }

    public static void Main(string[] args)
    {
        LinkedList<char> list = new LinkedList<char>();
        list.AddLast('a');
        list.AddLast('b');
        list.AddLast('c');
        list.AddLast('d');
        list.AddLast('e');
        list.AddLast('f');
        list.AddLast('g');
        list.AddLast('h');
        list.AddLast('i');
        list.AddLast('j');
        Console.WriteLine("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(FindNthElement(list, n));
    }
}