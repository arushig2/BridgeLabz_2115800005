 using System;

 class YardsMiles{
 	static void Main(string[] args){
		
 		double feet = Convert.ToDouble(Console.ReadLine());
		
		double yards = feet / 3;
		double miles = yards / 1760;
		
		Console.WriteLine("Distance in feet is " + feet + " while in yards is " + yards + " and miles is " + miles);
  	}
 }
 
 