using System;

class FahToCels{
	
	static void Main(string[] args){
		double fahrenheit = Convert.ToDouble(Console.ReadLine());
		double celsius = (fahrenheit - 32) * 5 / 9;
		Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius +" Celsius");
	}
}
