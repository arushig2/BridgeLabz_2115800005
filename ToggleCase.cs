using System;

class ToggleCase{
	
	public static string Toggle(string s){
		string ans = "";
		for(int i = 0; i < s.Length; i++){
			char ch = s[i];
			if(char.IsUpper(ch)){ //if character is upper case
				ans += char.ToLower(ch); //append to ans by converting to lower case
			} else { //else character is lower case 
				ans += char.ToUpper(ch); //append to ans by converting to upper case
			}
		}
		
		return ans;
	}
	public static void Main(string[] args){
		
	Console.Write("Enter a string: ");
	string s = Console.ReadLine(); //take input from user
	
	string ans = Toggle(s); //call to convert toggle case
	
	Console.WriteLine($"Modified String: {ans}"); //display answer
	}
}
	
	
	