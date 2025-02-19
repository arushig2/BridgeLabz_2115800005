using System;
using System.Collections;
using System.Collections.Generic;
public class Reverse
{
    public static void ReverseArrayList(ArrayList list)
    {
        int n = list.Count;
        int i = 0, j = n - 1;

        while (i <= j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
            i++;
            j--;
        }
    }

    public static void ReverseLinkedList(LinkedList<int> list)
    {
        if (list.Count <= 1)
            return;

        LinkedList<int> tempList = new LinkedList<int>();

        while (list.Count > 0)
        {
            LinkedListNode<int> lastNode = list.Last;
            list.RemoveLast();
            tempList.AddLast(lastNode.Value);
        }

        foreach (var item in tempList)
        {
            list.AddLast(item);
        }
    }

    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        ReverseArrayList(list);

        foreach (var item in list)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        LinkedList<int> list2 = new LinkedList<int>();
        list2.AddLast(1);
        list2.AddLast(2);
        list2.AddLast(3);
        list2.AddLast(4);
        list2.AddLast(5);
        ReverseLinkedList(list2);

        foreach (var item in list2)
        {
            Console.Write(item + " ");
        }
    }
}
