using System;

class LeapYear{
	static bool IsLeapYear(int year){
		if(year >= 1528) {
			if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
				return true;
			}
		}
		return false;
	}
		
		
	public static void Main(string[] args){
		Console.Write("Enter a year: ");
		int year = Convert.ToInt32(Console.ReadLine()); //take input from user	
		
		bool isLeapYear = IsLeapYear(year);
		
		if(isLeapYear){
			Console.WriteLine("Year is leap year");
		} else {
			Console.WriteLine("Year is not a leap year");
		}
		
	}
}
