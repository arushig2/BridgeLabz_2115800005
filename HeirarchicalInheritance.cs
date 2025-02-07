using System;

class Vehicle  // Parent
{
    public void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

class Car : Vehicle  //Child of Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

class Bike : Vehicle  // Child of Vehicle
{
    public void Ride()
    {
        Console.WriteLine("Bike is being ridden...");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Start();  // Inherited from Vehicle
        myCar.Drive();  // Defined in Car

        Console.WriteLine();

        Bike myBike = new Bike();
        myBike.Start();  // Inherited from Vehicle
        myBike.Ride();   // Defined in Bike
    }
}
