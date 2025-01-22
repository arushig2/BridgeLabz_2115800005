using System;

class Program{
	
	static void Main(string[] args){
		Console.Write("Enter distance in KiloMetres: ");
		double km = Convert.ToDouble(Console.ReadLine());
		double miles = km * 0.621371;
		Console.WriteLine("Distance in Miles: "+miles);
	}
}
