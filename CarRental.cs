using System;

public class CarRental
{
   private string customerName;
   private string carModel;
   private int rentalDays;
   private const int costPerDay = 450;

   public string CustomerName
   {
       get { return customerName; }
       set { customerName = value; }
   } 

   public string CarModel
   {
       get { return carModel; }
       set { carModel = value; }
   }

   public int RentalDays
   {
       get { return rentalDays; }
       set { rentalDays = value; }
   }
    
   public CarRental() //default constructor
	{
	}

   public CarRental(string customerName, string carModel, int rentalDays) //parametrised constructor
   {
       this.customerName = customerName;
       this.carModel = carModel;
       this.rentalDays = rentalDays;
   }

   public void TotalCost()
   {
       int cost = costPerDay * rentalDays; //calculate total cost
       Console.WriteLine($"{carModel} rented for {rentalDays} days by {customerName} at {costPerDay} cost each day, total cost = {cost}");
   }
}

public class Program
{
   public static void Main(string[] args)
   {
       CarRental car1 = new CarRental("Raj", "Thar", 10);
       car1.TotalCost();

       CarRental car2 = new CarRental("Manish", "Verna", 3);
       car2.TotalCost();
   }
}
