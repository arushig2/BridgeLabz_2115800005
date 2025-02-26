using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = @"
        [
            { ""name"": ""John Doe"", ""age"": 30, ""email"": ""john@example.com"" },
            { ""name"": ""Alice Smith"", ""age"": 22, ""email"": ""alice@example.com"" },
            { ""name"": ""Bob Johnson"", ""age"": 28, ""email"": ""bob@example.com"" }
        ]";

        JArray users = JArray.Parse(json);

        var filteredUsers = users.Where(u => (int)u["age"] > 25);

        foreach (var user in filteredUsers)
        {
            Console.WriteLine(user);
        }
    }
}
