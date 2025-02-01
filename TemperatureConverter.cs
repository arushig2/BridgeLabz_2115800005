using System;

class TempertaureConverter{
	static double GetInput(){
		double temp = Convert.ToDouble(Console.ReadLine()); //take input from use
		return temp;
	}
	public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        return celsius;
    }
	
	public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32; 
        return fahrenheit;
    }
	
	static void Output(double fahrenheit, double fahrenheit2Celsius, double celsius, double celsius2Fahrenheit){
		Console.WriteLine($"{fahrenheit}F to Celsius: {fahrenheit2Celsius}"); //display output
		Console.WriteLine($"{celsius}C to Fahrenheit: {celsius2Fahrenheit}"); //display output
	}
	
	static void Main(string[] args){
		Console.WriteLine("Enter temperature in Fahrenheit: ");
		double fahrenheit = GetInput();
		Console.WriteLine("Enter temperature in Celsius: ");
		double celsius = GetInput();
		
		double fahrenheit2Celsius = ConvertFahrenheitToCelsius(fahrenheit);
		double celsius2Fahrenheit = ConvertCelsiusToFahrenheit(celsius);
		
		Output(fahrenheit, fahrenheit2Celsius, celsius, celsius2Fahrenheit);
	}
}
		
		