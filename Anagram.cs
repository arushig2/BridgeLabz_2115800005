using System;

class Anagram{
	
	public static bool IsAnagram(string s, string t){
		int[] freqS = new int[256]; //to store freq of each character of string s 
		int[] freqT = new int[256]; //to store freq of each character of string t
		
		for(int i = 0; i < s.Length; i++){ //update freq of each character of string s 
			int ind = s[i] - 'a';
			freqS[ind]++;
		} 
		
		for(int i = 0; i < t.Length; i++){ //update freq of each character of string t
			int ind = t[i] - 'a';
			freqT[ind]++;
		}
		
		for(int i = 0; i < 256; i++){ //check if freq of each character is same
			if(freqS[i] != freqT[i]){
				return false;
			}
		}
		
		return true;
	}
	public static void Main(string[] args){
		
	Console.Write("Enter a string: ");
	string s = Console.ReadLine(); //take input from user
	
	Console.Write("Enter a string: ");
	string t = Console.ReadLine(); //take input from user
	
	bool ans = IsAnagram(s, t); //call to convert check if the string is anagram
	
	if(ans){
		Console.WriteLine($"The two strings are anagram"); //display answer
	} else {
		Console.WriteLine($"The two strings are not an anagram");
	}
	
	}
}
	
	
	