using System;

class Program{
	static void Main(string[] args){
		Console.Write("Enter Radius: ");
		int r = Convert.ToInt32(Console.ReadLine());
		double ar = Math.PI * Math.Pow(r, 2);
		Console.WriteLine("Area = " + ar);
	}
}