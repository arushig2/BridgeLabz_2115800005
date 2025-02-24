using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
    {
        T instance = new T();

        foreach (var property in properties)
        {
            FieldInfo fieldInfo = clazz.GetField(property.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {

                fieldInfo.SetValue(instance, property.Value);
            }
            else
            {
                Console.WriteLine($"Field '{property.Key}' not found in {clazz.Name}");
            }
        }

        return instance;
    }
}

class Person
{
    public string Name;
    private int Age;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, object> properties = new Dictionary<string, object>
        {
            { "Name", "Alice" },
            { "Age", 25 }
        };

        Person person = ObjectMapper.ToObject<Person>(typeof(Person), properties);

        person.Display();
    }
}
