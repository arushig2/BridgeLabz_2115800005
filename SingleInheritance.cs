using System;

class Vehicle  // Base class
{
    public void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

class Car : Vehicle  // Derived class 
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Start();  // Method from Vehicle class
        myCar.Drive();  // Method from Car class
    }
}
