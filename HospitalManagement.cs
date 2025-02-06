//using System;

//public class Patient
//{
//    public static string hospitalName = "City Hospital";
//    public static int totalPatients = 0;
//    public string name;
//    public string ailment;
//    public int age;
//    public readonly int patientId;


//    public Patient()
//    {
//        totalPatients++;
//    }

//    public Patient(string name, int age, string ailment, int patientId)
//    {
//        this.name = name;
//        this.age  = age;
//        this.ailment = ailment;  
//        this.patientId = patientId;
//        totalPatients++;
//    }

//    public static void GetTotalPatients()
//    {
//        Console.WriteLine($"Total Patients : {totalPatients}");
//    }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Hospital Name: {hospitalName}");
//        Console.WriteLine($"Patient Name: {name}");
//        Console.WriteLine($"Patient Id.: {patientId}");
//        Console.WriteLine($"Patient Age: {age}");
//        Console.WriteLine($"ailment: {ailment}");

//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        object obj1 = new Patient("Ravi", 34, "fever", 124);
//        object obj2 = new Patient("Rishi", 23, "Diabetes", 432);
//        object obj3 = "Not an Patient";

//        if (obj1 is Patient patient1)
//        {
//            patient1.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj1 is not an instance of Patient.");
//        }



//        if (obj2 is Patient patient2)
//        {
//            patient2.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj2 is not an instance of Patient.");
//        }


//        Patient.GetTotalPatients();
//        if (obj3 is Patient patient3)
//        {
//            patient3.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj3 is not an instance of Patient.");
//        }

//    }
//}
