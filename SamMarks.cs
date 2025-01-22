using System;

class SamMarks{
	static void Main(string[] args){
		int maths = 94;
		int phy = 95;
		int chem = 96;
		int sum = maths + phy + chem;
		int avg = sum / 3;
		
		Console.WriteLine("Sam’s average mark in PCM is "+avg);
	}
}