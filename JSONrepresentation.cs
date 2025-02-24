using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

class JsonConverter
{
    public static string ToJson(object obj)
    {
        if (obj == null) return "{}";

        Type type = obj.GetType();
        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("{");

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        List<string> jsonProperties = new List<string>();

        foreach (var field in fields)
        {
            object value = field.GetValue(obj);
            string formattedValue = value is string ? $"\"{value}\"" : value.ToString();
            jsonProperties.Add($"\"{field.Name}\": {formattedValue}");
        }

        jsonBuilder.Append(string.Join(", ", jsonProperties));
        jsonBuilder.Append("}");
        return jsonBuilder.ToString();
    }
}

class Person
{
    public string Name = "Alice";
    private int Age = 25;
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        string json = JsonConverter.ToJson(person);
        Console.WriteLine("JSON Representation:");
        Console.WriteLine(json);
    }
}
