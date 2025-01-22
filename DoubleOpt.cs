 using System;

 class DoubleOpt{
 	static void Main(string[] args){
		
 		double a = Convert.ToDouble(Console.ReadLine());
		double b = Convert.ToDouble(Console.ReadLine());
		double c = Convert.ToDouble(Console.ReadLine());
		
		double op1 = a + b * c;
		double op2 = a * b + c;
		double op3 = c + a / b;
		double op4 = a % b + c;
				
		Console.WriteLine("The results of Double Operations are " + op1 + ", " + op2 + ", " + op3 + " and "  + op4);
  	}
 }