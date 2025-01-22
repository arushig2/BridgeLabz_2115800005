using System;

class Salary{
	
	static void Main(string[] args){
		double salary = Convert.ToDouble(Console.ReadLine());
		double bonus = Convert.ToDouble(Console.ReadLine());
		
		double totalSalary = salary + bonus;
		Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalSalary);
	}
}
