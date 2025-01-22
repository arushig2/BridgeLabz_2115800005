 using System;

 class EarthVol{
 	static void Main(){
		
 		double radiusInKm = 6378;
		double pi = 3.14;
		double kmCube = Math.Pow(radiusInKm, 3);
		
		double volInKm = (4 / 3) * pi * kmCube;
		
		double miles = 1.6;
		double radiusInMiles = radiusInKm * miles;
		double milesCube = Math.Pow(radiusInMiles, 3);
		double volInMile = (4 / 3) * pi * milesCube;
		
		
 		Console.WriteLine("The volume of earth in cubic kilometers is "+volInKm + " and cubic miles is " +volInMile);

  	}
 }