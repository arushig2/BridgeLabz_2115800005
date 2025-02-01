using System;

class LongestWord{
	
	public static string LongestWordInSentence(string s){
		int maxLen = 0; //to track maximum length
		int i = 0; //to traverse the string
		string longestWord = ""; //to track the longest word
		string wrd = ""; //to track current word
		int len = 0; //to track current length
		while(i < s.Length){
			if(s[i] != ' '){ //if current character is not a space add it to current word and increase current length
				wrd += s[i]; 
				len++;
			} else { //if current character is a space it means one word is completed
				if(len > maxLen){ //check if current length is greater than maxLen
					maxLen = len; //update maxLen
					longestWord = wrd; //update longestWord
				}
				len = 0; //reset len and wrd
				wrd = "";
			}
			i++;
		}
		
		if(len > maxLen){ //for last word 
			maxLen = len;
			longestWord = wrd;
		}
		
		return longestWord;
	}
	public static void Main(string[] args){
		
	Console.WriteLine("Enter a string: ");
	string s = Console.ReadLine(); //take input from user
	
	string ans = LongestWordInSentence(s); //call to find longest word in the sentence
	
	Console.WriteLine($"Longest Word: {ans}"); //display answer
	}
}
	
	
	