using System;

class StudentVote{
	public static void Main(string[] args){
		int[] ages = new int[10]; //declare and array of size 10
		
		for(int i = 0; i < 10; i++){
		Console.Write("Enter age of student " + (i+1) + ":");
			ages[i] = Convert.ToInt32(Console.ReadLine()); //take input from user
		}
		
		for(int i = 0; i < ages.Length; i++){
			if(ages[i] < 0) Console.WriteLine("Invalid Age"); //negative age
			else if(ages[i] < 18) Console.WriteLine("Student with age " + ages[i] + " cannot vote"); //age less than 18
			else Console.WriteLine("Student with age " + ages[i] + " can vote"); //age greater than or equal to 18
		}
	}
}