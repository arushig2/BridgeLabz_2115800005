using System;
using Newtonsoft.Json;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main()
    {
        Car car = new Car
        {
            Make = "Toyota",
            Model = "Camry",
            Year = 2022
        };

        string json = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine(json);
    }
}
