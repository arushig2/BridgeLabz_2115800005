using System;
interface IOperations
{
   void Subtract(int a, int b);
}

abstract class Calculator
{
   public void Add(int a, int b) 
   {
       Console.WriteLine($"Addition: {a + b}");
   }
}

class AdvancedCalculator : Calculator, IOperations
{
   public void Subtract(int a, int b) 
   {
       Console.WriteLine($"Subtraction: {a - b}");
   }
}

class Program
{
   static void Main()
   {
       AdvancedCalculator calc = new AdvancedCalculator();
       calc.Add(10, 5);      
       calc.Subtract(10, 5); 
   }
}
