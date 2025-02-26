using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        string schemaJson = @"
        {
            ""type"": ""object"",
            ""properties"": {
                ""name"": { ""type"": ""string"" },
                ""email"": { ""type"": ""string"", ""format"": ""email"" },
                ""age"": { ""type"": ""integer"", ""minimum"": 18 }
            },
            ""required"": [""name"", ""email""]
        }";

        string jsonData = @"
        {
            ""name"": ""John Doe"",
            ""email"": ""john.doe@example.com"",
            ""age"": 25
        }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject jsonObject = JObject.Parse(jsonData);

        IList<ValidationError> errors;

        if (jsonObject.IsValid(schema, out errors))
        {
            Console.WriteLine("JSON is valid!");
        }
        else
        {
            Console.WriteLine("JSON is invalid:");
            foreach (var error in errors)
            {
                Console.WriteLine($"- {error.Message}");
            }
        }
    }
}
