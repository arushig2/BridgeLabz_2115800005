using System;

class LeapYearLogical{
    static void Main(string[] args){
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());
        
        if(year < 1582){
            Console.WriteLine("Invalid Input: Leap year concept started in 1582.");
        } else {			
			if((year % 4 == 0 && year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)){
				Console.WriteLine(year + " is a leap year.");
			} else {
				Console.WriteLine(year + " is not a leap year.");
			}
        }
    }
}
