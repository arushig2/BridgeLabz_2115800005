using System;

class RemoveDuplicates{
	public static string DuplicateRemove(string s){
		int[] freq = new int[256]; //declare a freq array of size 256 for all characters
		int i = 0;
		string ans = "";
		
		while(i < s.Length){
			int charVal = s[i]; //convert character to int value to access in array
			
			if(freq[charVal] == 0){ //check if character has already appeared if not
				ans += s[i]; //append to answer string
				freq[charVal]++;
			} 
			i++;
		}
		
		return ans;
	}
	public static void Main(string[] args){
		
	Console.WriteLine("Enter a string: ");
	string s = Console.ReadLine(); //take input from user
	
	string ans = DuplicateRemove(s); //call duplicate remove function
	
	Console.WriteLine($"Duplicates Removed: {ans}"); //display answer
	}
}
	
	
	