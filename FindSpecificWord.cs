using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] sentences = {
            "The quick brown fox jumps over the lazy dog.",
            "Hello world!",
            "C# programming is fun.",
            "Practice makes perfect.",
            "Search algorithms are useful."
        };

        string wordToSearch = "programming";
        string result = LinearSearchSentence(sentences, wordToSearch);

        if (!string.IsNullOrEmpty(result))
        {
            Console.WriteLine("First sentence containing the word: " + result);
        }
        else
        {
            Console.WriteLine("No sentence found containing the word.");
        }
    }

    static string LinearSearchSentence(string[] sentences, string word)
    {
        foreach (string sentence in sentences)
        {
            if (sentence.Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                return sentence;
            }
        }
        return string.Empty;
    }
}
