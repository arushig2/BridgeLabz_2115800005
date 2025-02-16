using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment24\\TestText1.txt";
        string wordToCount = "hi";
        int count = 0;
        StreamReader reader = new StreamReader(filePath);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
            count += CountOccurrences(line, wordToCount);
        }

        Console.WriteLine($"The word '{wordToCount}' appears {count} times in the file.");
    }

    static int CountOccurrences(string text, string word)
    {
        int count = 0;
        int index = 0;
        while ((index = text.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += word.Length;
        }
        return count;
    }
}
