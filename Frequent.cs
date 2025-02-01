using System;

class Frequent{
	
	public static char MostFrequentCharacter(string s){
		int[] freq = new int[256]; //to store freq of each character of string s 
				
		for(int i = 0; i < s.Length; i++){ //update freq of each character of string s 
			int ind = (int)s[i];
			freq[ind]++;
		} 
		
		int maxFreq = 0;
		char ans = ' ';
		
		for(int i = 0; i < 256; i++){ 
			if(freq[i] > maxFreq){ //check if freq is greater than maxFreq if yes, update values
				maxFreq = freq[i];
				ans = (char)(i);
			}
		}
		
		return ans;
	}
	public static void Main(string[] args){
		
	Console.Write("Enter a string: ");
	string s = Console.ReadLine(); //take input from user
		
	char ans = MostFrequentCharacter(s); //call to find the most frequent character
	
	Console.WriteLine($"The most frequent character is {ans}"); //display answer
	
	}
}
	
	
	