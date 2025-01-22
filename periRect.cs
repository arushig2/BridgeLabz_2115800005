using System;

class Program{
	static void Main(string[] args){
		Console.Write("Enter length: ");
		int l = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter breadth: ");
		int b = Convert.ToInt32(Console.ReadLine());
		
		int peri = 2 * (l + b);
		
		Console.Write("Perimeter = " + peri);
	}
}
		
		