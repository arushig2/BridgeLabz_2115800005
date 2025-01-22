 using System;

 class IntOperations{
 	static void Main(string[] args){
		
 		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());
		
		int op1 = a + b * c;
		int op2 = a * b + c;
		int op3 = c + a / b;
		int op4 = a % b + c;
				
		Console.WriteLine("The results of Int Operations are " + op1 + ", " + op2 + ", " + op3 + " and "  + op4);
  	}
 }