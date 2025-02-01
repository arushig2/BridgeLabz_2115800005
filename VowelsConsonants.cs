using System;

class VowelsConsonants{
	public static void Main(string[] args){
		
		Console.Write("Enter a string: ");
		string s = Console.ReadLine(); //take input from user
		
		int vowels = 0, consonants = 0; //variable to count vowels and consonants
		
		s = s.ToLower(); //convert string to lowercase
		
		for(int i = 0; i < s.Length; i++){
			if(s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'){ //if character is a vowel
				vowels++;
			} else { //if character is a consonant
				consonants++;
			}
		}
		
		//display result
		Console.Write($"Number of vowels: {vowels}\n");
		Console.Write($"Number of consonants: {consonants}");
	}
}
	
	