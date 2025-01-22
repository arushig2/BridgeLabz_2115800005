 using System;

 class CmToFeet{
 	static void Main(string[] args){
		
 		double cm = Convert.ToDouble(Console.ReadLine());
		double feet = 12; //1 foot = 12 inches
		double inch = 2.54; //1 inch = 2.54 cm
		double heightInInch = cm / inch;
		double heightInFeet = heightInInch / feet;
		
		Console.WriteLine(" Your Height in cm is " + cm + " while in feet is " + heightInFeet + " and inches is " + heightInInch);
  	}
 }