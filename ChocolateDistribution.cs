using System;

class ChocolateDistribution{
	static void Main(){
		
 		int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
 		int numberOfChildren = Convert.ToInt32(Console.ReadLine());
 		int eachStudent = numberOfChocolates / numberOfChildren;
		int remaining = numberOfChocolates % numberOfChildren;
		
		Console.WriteLine("The number of chocolates each child gets is " + eachStudent + " and the number of remaining chocolates is  "+remaining);

 	}
}