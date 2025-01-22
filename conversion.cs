using System;

class Program{
	
	static void Main(string[] args){
		Console.WriteLine("Enter temperature in Celcius:");
		double celcius = Convert.ToDouble(Console.ReadLine());
		double fahrenheit = (celcius * 9 / 5) + 32;
		Console.WriteLine("Temperature in Fahrenheit: "+fahrenheit);
	}
}
