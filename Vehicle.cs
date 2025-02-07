using System;
interface IDriveable
{
    void Drive();
}

abstract class Vehicle
{
    public abstract void Refuel();
}

class Car : Vehicle, IDriveable
{
    public override void Refuel() => Console.WriteLine("Refueling car...");
    public void Drive() => Console.WriteLine("Driving...");
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Refuel();  
        myCar.Drive();   

        // Using interface reference
        IDriveable driveableCar = new Car();
        driveableCar.Drive(); 

        // Using abstract class reference
        Vehicle vehicleCar = new Car();
        vehicleCar.Refuel(); 
    }
}
