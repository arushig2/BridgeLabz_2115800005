using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json1 = @"{ ""name"": ""John Doe"", ""email"": ""john.doe@example.com"" }";
        string json2 = @"{ ""age"": 30, ""city"": ""New York"" }";

        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);

        obj1.Merge(obj2, new JsonMergeSettings
        {
            MergeArrayHandling = MergeArrayHandling.Union
        });

        Console.WriteLine(obj1.ToString());
    }
}
