using System;

class Program{
	static void Main(string[] args){
		Console.Write("Enter radius: ");
		double r = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Height: ");
		double h = Convert.ToDouble(Console.ReadLine());
		
		double vol = 3.14 * Math.Pow(r, 2) * h;
		
		Console.Write("Volume = " + vol);
	}
}
		
		