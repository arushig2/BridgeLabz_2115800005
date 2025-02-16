using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment24\\UserInput.txt";

        Console.WriteLine("Enter text to write to file (type 'exit' to stop):");
        StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8);
        string input;
        while ((input = Console.ReadLine()) != null && input.ToLower() != "exit")
        {
            writer.WriteLine(input);
        }

        Console.WriteLine("User input has been written to the file.");
    }
}


