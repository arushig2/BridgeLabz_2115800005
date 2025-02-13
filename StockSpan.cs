using System;
using System.Collections.Generic;

public class Program
{
    public static int[] StockSpan(int[] arr)
    {
        Stack<int> st = new Stack<int>();

        int[] ans = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            //pop till the top element of stack is less than or equal to the current element
            while (st.Count != 0 && arr[st.Peek()] <= arr[i])
            {
                st.Pop();
            }
            //if stack is empty
            if (st.Count == 0)
            {
                ans[i] = i + 1;
            }
            //top element is the index of previous highest price
            else
            {
                ans[i] = i - st.Peek();
            }

            st.Push(i);
        }

        return ans;

    }
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[num];

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Enter price of stock: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] ans = StockSpan(arr);

        //Display answer
        for (int i = 0; i < ans.Length; i++)
        {
            Console.WriteLine(ans[i] + " ");
        }

    }
}
