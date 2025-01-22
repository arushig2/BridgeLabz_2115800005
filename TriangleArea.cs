 using System;

 class TriangleArea{
 	static void Main(string[] args){
		
 		double baseTri	= Convert.ToDouble(Console.ReadLine());
		double height = Convert.ToDouble(Console.ReadLine());
		double area = 0.5 * baseTri * height;
		double areaInInches = area * Math.Pow(0.393, 2);
		
		Console.WriteLine("Area of Triangle in sq. cm is " + area + " and in sq. inches is " + areaInInches);
  	}
 }