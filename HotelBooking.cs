using System;

public class HotelBooking
{
   private string guestName;
   private string roomType;
   private int nights;

   public string GuestName //getter setter
   {
       get { return guestName; }
       set { guestName = value; }
   }

   public string RoomType 
   {
       get { return roomType; }
       set { roomType = value; }
   }

   public int Nights
   {
       get { return nights; }
       set { nights = value; }
   }


   public HotelBooking() //default constructor
	{

	}

   public HotelBooking(string guestName,  string roomType, int nights) //parametrized constructor
   {
       this.guestName = guestName;
       this.roomType = roomType;
       this.nights = nights;
   }

   public HotelBooking(HotelBooking obj) //copy constructor
   {
       this.guestName= obj.guestName;
       this.roomType= obj.roomType;
       this.nights = obj.nights;
   }

   public void Display()
   {
       Console.WriteLine($"Guest Name: {guestName}");
       Console.WriteLine($"Room Type: {roomType}");
       Console.WriteLine($"Number of nights to stay: {nights}");
   }
}

public class Program
{
   public static void Main(string[] args)
   {
       HotelBooking obj1 = new HotelBooking(); //default constructor
       Console.WriteLine("Guest1");
       obj1.Display();

        
       HotelBooking obj2 = new HotelBooking(); //using getter and setter
       Console.WriteLine("Enter guest name: ");
       obj2.GuestName = Console.ReadLine();
       Console.WriteLine("Enter room type: ");
       obj2.RoomType = Console.ReadLine();
       Console.WriteLine("Enter number of nights to stay: ");
       obj2.Nights = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Guest2");
       obj2.Display();

        
       Console.WriteLine("Enter guest name: ");
       string guestName = Console.ReadLine();
       Console.WriteLine("Enter room type: ");
       string roomType = Console.ReadLine();
       Console.WriteLine("Enter number of nights to stay: ");
       int nights = Convert.ToInt32(Console.ReadLine());
       HotelBooking obj3 = new HotelBooking(guestName, roomType, nights); //parametrized constructor
       Console.WriteLine("Guest3");
       obj3.Display();

       HotelBooking obj4 = new HotelBooking(obj2); //copy constructor
       Console.WriteLine("Guest4");
       obj4.Display();

   }
}

