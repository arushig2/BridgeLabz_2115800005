using System;

class SubstringOccurrences{
	
    public static int CountSubstringOccurrences(string s, string t){
        int count = 0;
        int sLength = s.Length;
        int tLength = t.Length;

        for (int i = 0; i <= sLength - tLength; i++){
            bool match = true;
            for (int j = 0; j < tLength; j++){ // Check if substring matches at the current position
                if (s[i + j] != t[j]){
                    match = false;
                    break;
                }
            }

            if (match){
                count++;
            }
        }

        return count;
    }

    public static void Main(string[] args){
        Console.Write("Enter the main string: ");
        string s = Console.ReadLine();

        Console.Write("Enter the substring to count: ");
        string t = Console.ReadLine();

        int ans = CountSubstringOccurrences(s, t);

        Console.WriteLine($"The substring '{t}' occurs {ans} times in the given string.");
    }
}
