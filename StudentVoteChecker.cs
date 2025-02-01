using System;

class StudentVoteChecker{
	
	public static bool CanStudentVote(int age){
		if(age < 0) return false;
		else if(age < 18) return false;
		else return true;
	}
	
	public static void Main(string[] args){
		int[] ages = new int[10]; //declare and array of size 10
		
		for(int i = 0; i < 10; i++){
		Console.Write("Enter age of student " + (i+1) + ":");
			ages[i] = Convert.ToInt32(Console.ReadLine()); //take input from user
		}
		
		for(int i = 0; i < ages.Length; i++){
			if(CanStudentVote(ages[i])){
				Console.WriteLine("Student " + (i + 1) + " can vote.");
			} else {
				Console.WriteLine("Student " + (i + 1) + " cannot vote.");
			}
		}
	}
}