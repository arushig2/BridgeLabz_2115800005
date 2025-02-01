using System;

class SimpleInterest{
	
	public static double SimpleInterestCalculate(double p, double r, double t){
		double si = (p * r * t) / 100; //calculate simple interest
		return si;
		
	}
	
	static void Main(string[] args){
		Console.Write("Enter Principal: ");
		double p = Convert.ToDouble(Console.ReadLine()); //take input for principal
		Console.Write("Enter Rate: ");
		double r = Convert.ToDouble(Console.ReadLine()); //take input for rate
		Console.Write("Enter Time: ");
		double t = Convert.ToDouble(Console.ReadLine()); //take input for time
		
		double si = SimpleInterestCalculate(p, r, t); //Call SimpleInterestCalculate function
		
		//Display result
		Console.Write("The Simple Interest is " + si + " for Principal " + p + ", Rate of Interest " + r + " and Time " + t);
	
	}
}
		