 using System;

 class Swap{
 	static void Main(string[] args){
		
 		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		
		a = a + b;
		b = a - b;
		a = a - b;
				
		Console.WriteLine("The swapped numbers are " + a + " and " + b);

  	}
 }