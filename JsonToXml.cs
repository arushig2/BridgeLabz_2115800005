using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string json = @"
        {
            ""name"": ""John Doe"",
            ""age"": 30,
            ""email"": ""john.doe@example.com"",
            ""address"": {
                ""city"": ""New York"",
                ""zip"": ""10001""
            }
        }";


        JObject jsonObject = JObject.Parse(json);
        XDocument xml = JsonConvert.DeserializeXNode(jsonObject.ToString(), "Root");

        Console.WriteLine(xml.ToString());
    }
}
