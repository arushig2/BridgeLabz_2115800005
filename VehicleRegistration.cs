using System;

public class Vehicle
{
   private string ownerName;
   private string vehicleType;
   private static double registrationFee = 5000;

   public string OwnerName
   {
       get { return ownerName; }
       set { ownerName = value; }
   }

   public string VehicleType
   {
       get { return vehicleType; }
       set { vehicleType = value; }
   }

   public Vehicle()
   {
   }

   public Vehicle(string ownerName, string vehicleType)
   {
       this.ownerName = ownerName;
       this.vehicleType = vehicleType;
   }

   public void DisplayVehicleDetails()
   {
       Console.WriteLine($"Owner Name: {ownerName}");
       Console.WriteLine($"Vehicle: {vehicleType}");
       Console.WriteLine($"Registration Fee: {registrationFee}");
   }

   public static void UpdateRegistrationFee(double newFee)
   {
       registrationFee = newFee;
   }
}

class Program
{
   public static void Main(string[] args)
   {
       Vehicle vehicle1 = new Vehicle("Raj", "Car");
       vehicle1.DisplayVehicleDetails();
       Vehicle.UpdateRegistrationFee(4000);
       vehicle1.DisplayVehicleDetails();

   }
}
