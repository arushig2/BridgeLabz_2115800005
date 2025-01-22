using System;

class SimpleInterest{
	static void Main(string[] args){
		Console.Write("Enter Principal: ");
		double p = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Rate: ");
		double r = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Time: ");
		double t = Convert.ToDouble(Console.ReadLine());
		
		double si = (p * r * t) / 100;
		
	Console.Write("The Simple Interest is " + si + " for Principal " + p + ", Rate of Interest " + r + " and Time " + t);
	}
}

		
		