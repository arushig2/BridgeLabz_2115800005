using System;

class WindChill{
	
	public static double CalculateWindChill(double temperature, double windSpeed){
		double windChill = 35.74 + (0.6215 * temperature) + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
		return windChill;

	 }
	public static void Main(string[] args){
		//take input from user
		Console.WriteLine("Enter temperature: ");
 		double temperature = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter wind speed: ");
 		double windSpeed = Convert.ToDouble(Console.ReadLine());
		
		double windChillTemp = CalculateWindChill(temperature, windSpeed); //call method to find wind chill temperature
		
		//display the result
		Console.WriteLine("The wind chill temperature is " + windChillTemp);

 	}
}