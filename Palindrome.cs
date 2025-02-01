using System;

class Palindrome{
	public static void Main(string[] args){
		
		Console.Write("Enter a string: ");
		string s = Console.ReadLine(); //take input from user
		
		string rev = "";
		
		for(int i = s.Length - 1; i >= 0; i--){ //run a reverse loop from end of string
			rev += s[i]; //append each character to the rev string
		}
		
		display result
		if(rev == s){
			Console.Write($"String is palindrome");
		} else {
			Console.Write($"String is not palindrome");
		}	
	}
}
	
	