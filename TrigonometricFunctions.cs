using System;

class TrigonometricFunctions
{
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        
        double radians = Math.PI * angle / 180.0; // Convert angle from degrees to radians

        double sine = Math.Sin(radians); //calulate sine
        double cosine = Math.Cos(radians); //calculate cosine
        double tangent = Math.Tan(radians); //calculate tangent

        return new double[] { sine, cosine, tangent };
    }

    public static void Main(string[] args)
    {
		// Take angle input from the user
        Console.WriteLine("Enter an angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] results = CalculateTrigonometricFunctions(angle);// Call the method to calculate trigonometric functions
		
		Console.WriteLine("Sine of " + angle + ": " + results[0]);
        Console.WriteLine("Cosine of " + angle + ": " + results[1]);
        Console.WriteLine("Tangest of " + angle + ": " + results[2]);
      
    }
}
