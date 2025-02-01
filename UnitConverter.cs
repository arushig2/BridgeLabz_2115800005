using System;
public class UnitConverter
{	
	public static double ConvertKmToMiles(double km)
    {
        double kmToMilesFactor = 0.621371;
        return km * kmToMilesFactor;
    }
	public static double ConvertMilesToKm(double miles)
    {
        double milesToKmFactor = 1.60934;
        return miles * milesToKmFactor;
    }
	
	public static double ConvertMetresToFeet(double metres)
    {
        double metresToFeetFactor = 3.28084;
        return metres * metresToFeetFactor;
    }
	
	public static double ConvertFeetToMetres(double feet)
    {
        double feetToMetresFactor = 0.3048;
        return feet * feetToMetresFactor;
    }
	
    public static void Main(string[] args)
    {
        //Take input from the user
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        //Call the static method and display the result
        double miles = ConvertKmToMiles(km);
        Console.WriteLine("Distance in miles: " + miles);
		
		//Take input from the user
        Console.Write("Enter the distance in miles: ");
        double mile = Convert.ToDouble(Console.ReadLine());

       // Call the static method and display the result
        double kms = ConvertMilesToKm(miles);
        Console.WriteLine("Distance in kilometers: " + kms);
		
		//Take input from the user
        Console.Write("Enter the distance in metres: ");
        double metres = Convert.ToDouble(Console.ReadLine());

        //Call the static method and display the result
        double feet = ConvertMetresToFeet(metres);
        Console.WriteLine("Distance in feet: " + feet);
		
		//Take input from the user
        Console.Write("Enter the distance in feet: ");
        double feets = Convert.ToDouble(Console.ReadLine());

        //Call the static method and display the result
        double metre = ConvertFeetToMetres(feets);
        Console.WriteLine("Distance in metres: " + metre);

    }
}
