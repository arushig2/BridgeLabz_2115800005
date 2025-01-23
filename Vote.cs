using System;

class Vote{
	static void Main(string[] args){
		//take age as input from user
 		int age = Convert.ToInt32(Console.ReadLine());
		Console.Write("The person's age is " + age + " and ");
		
		if(age >= 18){ //if person is more than 18years old then they can vote
			Console.WriteLine("can vote ");
		} else { //if person is less than 18years old
			Console.WriteLine("cannot vote ");
		}
 	}
}