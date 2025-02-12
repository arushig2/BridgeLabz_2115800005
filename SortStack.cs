using System;
using System.Collections.Generic;
public class Program
{    
   public static void Insert(Stack<int> stack, int temp)
   {
       if (stack.Count == 0 || stack.Peek() <= temp)
       {
           stack.Push(temp);
           return;
       }

       int top = stack.Pop();
       Insert(stack, temp);
       stack.Push(top);
   }

   public static void SortStack(Stack<int> stack)
   {
       if(stack.Count == 0) return;

       int top = stack.Pop();
       SortStack(stack);
       Insert(stack, top);
   }
   public static void Main(string[] args)
   {
       Stack<int> st = new Stack<int>();

       while (true)
       {
           Console.WriteLine("Enter a number: ");
           int n = Convert.ToInt32(Console.ReadLine());
           if (n == -1) break;

           st.Push(n);
       }

       SortStack(st);

       while (st.Count != 0)
       {
           Console.WriteLine(st.Pop());
       }
   }
}
