using System;

class Program{
	static void Main(string[] args){
		Console.Write("Enter base: ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter exponent: ");
		int e = Convert.ToInt32(Console.ReadLine());
		
		double pow = Math.Pow(b, e);
		
		Console.Write("Calculated Power = " + pow);
	}
}
		
		