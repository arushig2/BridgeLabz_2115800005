using System;

class Palindrome{
	static string GetInput(){
		Console.Write("Enter a string: ");
		string s = Console.ReadLine();
		return s;
	}
	
	static bool IsPalindrome(string s){
		string rev = "";
		
		for(int i = s.Length - 1; i >= 0; i--){
			rev += s[i]; //reverse the string
		}
		
		return (rev == s); //return if reverse is same as string 
	}
	
	static void Output(bool palindrome){
		if(palindrome){ //if true
			Console.WriteLine("String is palindrome");
		} else {
			Console.WriteLine("String is not palindrome");
		}
	}
	
    static void Main(){
		
        string s = GetInput(); //take input from user
		bool palindrome = IsPalindrome(s); //check if palindrome
		Output(palindrome); //display output
	   
    }
}
