using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = @"
        [
            { ""name"": ""John Doe"", ""age"": 30, ""email"": ""john.doe@example.com"" },
            { ""name"": ""Alice Smith"", ""age"": 22, ""email"": ""alice@example.com"" },
            { ""name"": ""Bob Johnson"", ""age"": 28, ""email"": ""bob@example.com"" }
        ]";

        JArray jsonArray = JArray.Parse(json);

        var filteredRecords = jsonArray
            .Where(record => record["age"] != null && (int)record["age"] > 25)
            .ToList();

        string filteredJson = JsonConvert.SerializeObject(filteredRecords, Formatting.Indented);
        Console.WriteLine(filteredJson);
    }
}
