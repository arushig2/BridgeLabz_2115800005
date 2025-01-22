using System;

class CelcToFah{
	
	static void Main(string[] args){
		double celcius = Convert.ToDouble(Console.ReadLine());
		double fahrenheit = (celcius * 9 / 5) + 32;
		Console.WriteLine("The " + celcius + " Celsius is " + fahrenheit +" Fahrenheit");
	}
}
