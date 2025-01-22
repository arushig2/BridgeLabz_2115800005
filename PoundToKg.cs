using System;

class PoundToKg{
	
	static void Main(string[] args){
		double pounds = Convert.ToDouble(Console.ReadLine());
		double kg = pounds * 2.2;
		Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " + kg);
	}
}