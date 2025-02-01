using System;

class ReplaceWord{
    public static string CustomReplace(string sentence, string oldWord, string newWord){
        string result = "";
        int i = 0;
        int n = sentence.Length;
        int oldLen = oldWord.Length;

        while (i < n){
            bool match = true;

            // Check if oldWord matches at current position
            if (i + oldLen <= n){
                for (int j = 0; j < oldLen; j++){
                    if (sentence[i + j] != oldWord[j]){
                        match = false;
                        break;
                    }
                }
            }
            else{
                match = false;
            }

            if (match){
                result += newWord; // Append new word
                i += oldLen;       // Move index forward
            } else {
                result += sentence[i]; // Append current character
                i++;
            }
        }

        return result;
    }

    public static void Main(string[] args){
        Console.Write("Enter a sentence: ");
        string s = Console.ReadLine();

        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string result = CustomReplace(s, oldWord, newWord);

        Console.WriteLine($"Updated sentence: {result}");
    }
}
