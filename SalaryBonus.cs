using System;

class SalaryBonus{
	static void Main(string[] args){
		//Take input for salary and number of years of service
		Console.Write("Enter salary: ");		
 		double salary = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter years of service: ");
		int years = Convert.ToInt32(Console.ReadLine());
		double bonusAmount = 0.0;
		
		if(years > 5){ //if service years is greater than 5
			bonusAmount = salary * 5 / 100; //calculate bonus
		}
		
		Console.WriteLine("Bonus amount = "+bonusAmount); //display result
 	}
}