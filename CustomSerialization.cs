using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text.Json;

[AttributeUsage(AttributeTargets.Property)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

class User
{
    [JsonField("user_name")]
    public string Username { get; set; }

    [JsonField("user_email")]
    public string Email { get; set; }

    [JsonField("account_age")]
    public int Age { get; set; }

    public string IgnoreThis { get; set; }
}

class JsonSerializerHelper
{
    public static string SerializeToJson(object obj)
    {
        Dictionary<string, object> jsonDict = new Dictionary<string, object>();
        Type type = obj.GetType();
        PropertyInfo[] properties = type.GetProperties();

        foreach (PropertyInfo prop in properties)
        {
            var attribute = (JsonFieldAttribute)Attribute.GetCustomAttribute(prop, typeof(JsonFieldAttribute));

            if (attribute != null)
            {
                jsonDict[attribute.Name] = prop.GetValue(obj);
            }
        }

        return JsonSerializer.Serialize(jsonDict, new JsonSerializerOptions { WriteIndented = true });
    }
}

class Program
{
    static void Main()
    {
        User user = new User
        {
            Username = "JohnDoe",
            Email = "john@example.com",
            Age = 25,
            IgnoreThis = "This should not appear in JSON"
        };

        string jsonString = JsonSerializerHelper.SerializeToJson(user);
        Console.WriteLine(jsonString);
    }
}
