using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\file2.json";

        if (File.Exists(filePath))
        {
            string jsonContent = File.ReadAllText(filePath);
            JObject jsonObject = JObject.Parse(jsonContent);
            PrintJson(jsonObject);
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

    static void PrintJson(JToken json, string indent = "")
    {
        if (json is JObject obj)
        {
            foreach (var property in obj.Properties())
            {
                Console.WriteLine($"{indent}{property.Name}: {property.Value}");
                PrintJson(property.Value, indent + "  ");
            }
        }
        else if (json is JArray array)
        {
            int index = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"{indent}[{index}]");
                PrintJson(item, indent + "  ");
                index++;
            }
        }
    }
}
