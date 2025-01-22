using System;

class KmToMiles{
	static void Main(string[] args){
		
 		double distInKm = 10.8;
 		double  miles = 1.6;
 		double distInMiles = distInKm * miles;
		
		Console.WriteLine("The distance " + distInKm +"km in miles is " + distInMiles);
 	}
}