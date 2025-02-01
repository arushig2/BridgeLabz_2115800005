using System;
public class UnitConverter3
{	
	//Static Method to convert fahrenheit to celsius
	public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 4 / 9;
        return celsius;
    }
	
	//Static Method to convert celsius to fahrenheit
	public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32; 
        return fahrenheit;
    }
	
	//Static Method to convert pounds to kg
	public static double ConvertPoundsToKgs(double pounds)
    {
        double poundsToKgsFactor = 0.453592;
        return pounds * poundsToKgsFactor;
    }

	//Static Method to convert kg to pounds
	public static double ConvertKgsToPounds(double kgs)
    {
        double kgsToPoundsFactor = 2.20462;
        return kgs * kgsToPoundsFactor;
    }
	
	//Static Method to convert gallon to litres
	public static double ConvertGallonToLitres(double gallon)
    {
        double gallonToLitresFactor =  3.78541; 
        return gallon * gallonToLitresFactor;
    }
	
	//Static Method to convert litres to gallons
	public static double ConvertLitresToGallons(double litres)
    {
        double litresToGallonsFactor = 0.264172; 
        return litres * litresToGallonsFactor;
    }
	
    public static void Main(string[] args)
    {
        Console.Write("Enter the temperature in fahrenheit: ");
        double fah = Convert.ToDouble(Console.ReadLine());

        double cel = ConvertFahrenheitToCelsius(fah);
        Console.WriteLine("Temperature in celsius: " + cel);
		
        Console.Write("Enter the temperature in celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        
        double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine("Temperature in fahrenheit: " + fahrenheit);

        Console.Write("Enter the weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());

        double kgs = ConvertPoundsToKgs(pounds);
        Console.WriteLine("Weight in kilograms: " + kgs);
		
        Console.Write("Enter the weight in kilograms: ");
        double kg = Convert.ToDouble(Console.ReadLine());

        double pound = ConvertKgsToPounds(kg);
        Console.WriteLine("Weight in pounds: " + pound);
		
		Console.Write("Enter the quantity in gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());

        double litres = ConvertGallonToLitres(gallons);
        Console.WriteLine("Quantity in Litres: " + litres);
		
		Console.Write("Enter the quantity in litres: ");
        double litre = Convert.ToDouble(Console.ReadLine());

        double gallon = ConvertLitresToGallons(litre);
        Console.WriteLine("Quantity in gallons: " + gallon);
		
    }
}
