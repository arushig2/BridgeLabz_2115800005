 using System;

 class KmToMilesUser{
 	static void Main(){
		
 		double km = Convert.ToDouble(Console.ReadLine());
		double miles = 1.6;
		double distInMiles = km * miles;
		
		Console.WriteLine("The total miles is " + distInMiles + " mile for the given " + km + " km");


  	}
 }