using System;

class Program{
	static void Main(string[] args){
		Console.Write("Enter first number: ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter second number: ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter third number: ");
		int c = Convert.ToInt32(Console.ReadLine());
		double avg = (a + b + c) / 3;
		
		Console.Write("Calculated Average = " + avg);
	}
}
		
		