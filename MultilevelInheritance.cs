using System;

class Vehicle  // Parent
{
    public void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

class Car : Vehicle  // Child of Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }
}

class ElectricCar : Car  // Child of Car
{
    public void ChargeBattery()
    {
        Console.WriteLine("Electric car is charging...");
    }
}

class Program
{
    static void Main()
    {
        ElectricCar myTesla = new ElectricCar();
        myTesla.Start();       // Inherited from Vehicle
        myTesla.Drive();       // Inherited from Car
        myTesla.ChargeBattery(); // Defined in ElectricCar
    }
}
