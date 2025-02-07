using System;

class Vehicle  // Base class
{
    public virtual void Start()  
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

class Car : Vehicle  
{
    public override void Start()  // Overriding the Start method
    {
        Console.WriteLine("Car is starting with a key...");
    }
}

class Bike : Vehicle  
{
    public override void Start()  // Overriding the Start method
    {
        Console.WriteLine("Bike is starting with a self-start button...");
    }
}

class Program
{
    static void Main()
    {
        Vehicle myVehicle = new Vehicle();
        myVehicle.Start();  // Calls Vehicle's Start()

        Vehicle myCar = new Car();
        myCar.Start();  // Calls Car's overridden Start()

        Vehicle myBike = new Bike();
        myBike.Start();  // Calls Bike's overridden Start()
    }
}
