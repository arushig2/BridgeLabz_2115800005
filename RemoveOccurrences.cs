using System;

class RemoveOccurrences{
	
	public static string OccurenceRemoved(string s, char t){
		int i = 0; //to traverse the string
		string ans = ""; 
	
		while(i < s.Length){
			if(s[i] != t){ //if current character is not the character to be removed
				ans += s[i]; 
				
			} 
			i++;
		}
		
		return ans;
	}
	public static void Main(string[] args){
		
	Console.Write("Enter a string: ");
	string s = Console.ReadLine(); //take input from user
	
	Console.Write("Character to remove: ");
	char t = Convert.ToChar(Console.ReadLine());
	
	string ans = OccurenceRemoved(s, t); //call to remove all occurences
	
	Console.WriteLine($"Modified String: {ans}"); //display answer
	}
}
	
	
	