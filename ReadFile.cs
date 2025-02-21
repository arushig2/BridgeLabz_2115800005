using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment29\\info.txt"))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine(firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
