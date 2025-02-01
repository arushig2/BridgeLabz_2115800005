using System;

class CompareTwoStrings{
	
	public static string[] Compare(string s, string t){
		int i = 0, j = 0; //to traverse the strings
		string ansFirst = "", ansSecond = "";  //to store first string and second string
	
		while(i < s.Length && j < t.Length){
			if(s[i] > t[j]){ //if current character of s is less than i.e, comes before current char of t
				ansFirst = t;
				ansSecond = s;
				return new string[] { ansFirst, ansSecond }; //return when found difference
			}  else if(s[i] < t[j]){ //if current character of t comes before current char of s
				ansFirst = s;
				ansSecond = t;
				return new string[] { ansFirst, ansSecond };
			}
			i++;
			j++;
		}
		
		if(i < s.Length){ //if t is prefix of s
			ansFirst = t;
			ansSecond = s;
		}
		
		if(j < t.Length){ //if s is prefix of t
			ansFirst = s;
			ansSecond = t;
		}
		
		return new string[]{ansFirst, ansSecond};
	}
	public static void Main(string[] args){
		
	Console.Write("Enter a string: ");
	string s = Console.ReadLine(); //take input from user
	
	Console.Write("Enter a second string: ");
	string t = Console.ReadLine();
	
	string[] ans = Compare(s, t); //call to find lexicographical order
	
	Console.WriteLine($"\"{ans[0]}\" comes before \"{ans[1]}\" in lexicographical order"); //display answer
	}
}
	
	
	