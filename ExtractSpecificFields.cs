using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\file1.json";
        string jsonContent = File.ReadAllText(filePath);

        JObject jsonObject = JObject.Parse(jsonContent);
        string name = jsonObject["name"]?.ToString();
        string email = jsonObject["email"]?.ToString();

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
    }
}
