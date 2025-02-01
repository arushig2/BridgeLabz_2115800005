using System;
public class UnitConverter2
{	
	public static double ConvertYardsToFeet(double yards)
    {
        double yardsToFeetFactor = 3;
        return yards * yardsToFeetFactor;
    }
	public static double ConvertFeetToYards(double feet)
    {
        double feetToYardsFactor = 0.333333;
        return feet * feetToYardsFactor;
    }
	
	public static double ConvertMetresToInches(double metres)
    {
        double metresToInchesFactor = 39.3701;
        return metres * metresToInchesFactor;
    }
	
	public static double ConvertInchesToMetres(double inches)
    {
        double inchesToMetresFactor = 0.0254;
        return inches * inchesToMetresFactor;
    }
	
	public static double ConvertInchesToCentimetres(double inches)
    {
        double inchesToCentimetresFactor = 2.54;
        return inches * inchesToCentimetresFactor;
    }
	
    public static void Main(string[] args)
    {
		//yards to feet
        Console.Write("Enter the distance in yards: ");
        double yards = Convert.ToDouble(Console.ReadLine());

        //Call the static method and display the result
        double feet = ConvertYardsToFeet(yards);
        Console.WriteLine("Distance in feet: " + feet);
		
		//feet to yards
        Console.Write("Enter the distance in feet: ");
        double feets = Convert.ToDouble(Console.ReadLine());

        //Call the static method and display the result
        double yard = ConvertFeetToYards(feets);
        Console.WriteLine("Distance in yards: " + yard);
		
		//metres to inches
        Console.Write("Enter the distance in metres: ");
        double metres = Convert.ToDouble(Console.ReadLine());

        //Call the static method and display the result
        double inches = ConvertMetresToInches(metres);
        Console.WriteLine("Distance in inches: " + inches);
		
		//inches to metres
        Console.Write("Enter the distance in inches: ");
        double inch = Convert.ToDouble(Console.ReadLine());

        //Call the static method and display the result
        double metre = ConvertInchesToMetres(inch);
        Console.WriteLine("Distance in metres: " + metre);
		
		//inches to centimetres
		Console.Write("Enter the distance in inches: ");
        double inche = Convert.ToDouble(Console.ReadLine());

        //Call the static method and display the result
        double cm = ConvertInchesToCentimetres(inche);
        Console.WriteLine("Distance in centimetres: " + cm);
    }
}
