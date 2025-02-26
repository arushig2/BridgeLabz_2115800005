using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        string json = @"
        {
            ""name"": ""John Doe"",
            ""email"": ""john.doe@example.com""
        }";

        string schemaJson = @"
        {
            ""type"": ""object"",
            ""properties"": {
                ""name"": { ""type"": ""string"" },
                ""email"": { ""type"": ""string"", ""format"": ""email"" }
            },
            ""required"": [""name"", ""email""]
        }";

        JSchema schema = JSchema.Parse(schemaJson);

        JObject jsonData = JObject.Parse(json);

        IList<string> validationErrors;
        bool isValid = jsonData.IsValid(schema, out validationErrors);

        if (isValid)
        {
            Console.WriteLine("JSON is valid.");
        }
        else
        {
            Console.WriteLine("JSON is invalid:");
            foreach (string error in validationErrors)
            {
                Console.WriteLine($"- {error}");
            }
        }
    }
}
