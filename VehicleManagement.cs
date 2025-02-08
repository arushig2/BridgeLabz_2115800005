using System;

public interface IRefuelable
{
    void Refuel();
}

public class Vehicle
{
	public int maxSpeed;
    public string model;

    public Vehicle(int maxSpeed, string model)
	{
        this.maxSpeed = maxSpeed;
        this.model = model;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Max Speed: " + maxSpeed);
        Console.WriteLine("Model: " + model);
    }
}

public class PetrolVehicle : Vehicle, IRefuelable
{
    public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model)
    {
    }

    public void Refuel()
    {
        Console.WriteLine("Refueling petrol vehicle");
    }
}

public class  ElectricVehicle : Vehicle 
{
    public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model)
    {
    }

    public void Charge()
    {
        Console.WriteLine("Charging electric vehicle");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PetrolVehicle vehicle1 = new PetrolVehicle(250, "Verna");
        vehicle1.DisplayDetails();
        vehicle1.Refuel();

        Console.WriteLine();

        ElectricVehicle evehicle1 = new ElectricVehicle(150, "Tesla");
        evehicle1.DisplayDetails();
        evehicle1.Charge();
    }
}

