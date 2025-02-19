using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter the path of the text file: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            try
            {
                string text = File.ReadAllText(filePath);
                Dictionary<string, int> wordFrequency = CountWordFrequency(text);

                Console.WriteLine("\nWord Frequencies:");
                foreach (var pair in wordFrequency.OrderBy(p => p.Key))
                {
                    Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("The specified file does not exist.");
        }
    }

    static Dictionary<string, int> CountWordFrequency(string text)
    {
        string[] words = Regex.Matches(text.ToLower(), @"\b\w+\b")
                               .Select(m => m.Value)
                               .ToArray();

        Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (frequencyDict.ContainsKey(word))
                frequencyDict[word]++;
            else
                frequencyDict[word] = 1;
        }

        return frequencyDict;
    }
}
