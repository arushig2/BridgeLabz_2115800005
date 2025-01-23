using System;

class LeapYear{
    static void Main(string[] args){
        //take input year from user
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());
        
        //cehck if year is greater than 1582
        if(year < 1582){
            Console.WriteLine("Invalid Input: Leap year concept started in 1582.");
        } else {
            //if year is divisible by 4 and divisible by 100 as well as 400 then it is a leap yaear
            //if year is divisible by 4 and by 100 but not by 400 it is not a leap year
            //if year is divisible by 4 and not by 100 then it is a leap year
            //if year is not divisble by 4 is not a leap year
            if(year % 4 == 0){
                if(year % 100 == 0){
                    if(year % 400 == 0){
                        Console.WriteLine(year + " is a leap year.");
                    } else {
                        Console.WriteLine(year + " is not a leap year.");
                    }
                } else {
                    Console.WriteLine(year + " is a leap year.");
                }
            } else {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
