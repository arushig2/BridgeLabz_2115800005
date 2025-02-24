using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OriginalAPIKey";

    public static void PrintApiKey()
    {
        Console.WriteLine($"API_KEY: {API_KEY}");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Configuration);

        FieldInfo fieldInfo = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (fieldInfo != null)
        {

            string originalValue = (string)fieldInfo.GetValue(null);
            Console.WriteLine($"Original API_KEY: {originalValue}");

            fieldInfo.SetValue(null, "NewSecretAPIKey");

            string updatedValue = (string)fieldInfo.GetValue(null);
            Console.WriteLine($"Updated API_KEY: {updatedValue}");

            Configuration.PrintApiKey();
        }
        else
        {
            Console.WriteLine("Field 'API_KEY' not found.");
        }
    }
}
