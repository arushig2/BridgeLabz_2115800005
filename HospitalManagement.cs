using System;

public abstract class Patient
{
    private int patientId;
    private string name;
    private int age;

    public int PatientId
    {
        get { return patientId; }
        set { patientId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Patient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public abstract void CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

public interface IMedicalRecord
{
    public void AddRecord();
    public void ViewRecord();

}

public class InPatient : Patient, IMedicalRecord
{
    private string roomNumber;
    private string bedNumber;
    private double dailyRate;
    public string RoomNumber
    {
        get { return roomNumber; }
        set { roomNumber = value; }
    }
    public string BedNumber
    {
        get { return bedNumber; }
        set { bedNumber = value; }
    }
    public double DailyRate
    {
        get { return dailyRate; }
        set { dailyRate = value; }
    }
    public InPatient(int patientId, string name, int age, string roomNumber, string bedNumber, double dailyRate) : base(patientId, name, age)
    {
        this.roomNumber = roomNumber;
        this.bedNumber = bedNumber;
        this.dailyRate = dailyRate;
    }
    public override void CalculateBill()
    {
        Console.WriteLine("Total bill: " + dailyRate);
    }
    public void AddRecord()
    {
        Console.WriteLine("Record added successfully");
    }
    public void ViewRecord()
    {
        Console.WriteLine("Record viewed successfully");
    }
}

public class OutPatient : Patient, IMedicalRecord
{
    private string doctorName;
    private double consultationFee;
    public string DoctorName
    {
        get { return doctorName; }
        set { doctorName = value; }
    }
    public double ConsultationFee
    {
        get { return consultationFee; }
        set { consultationFee = value; }
    }
    public OutPatient(int patientId, string name, int age, string doctorName, double consultationFee) : base(patientId, name, age)
    {
        this.doctorName = doctorName;
        this.consultationFee = consultationFee;
    }
    public override void CalculateBill()
    {
        Console.WriteLine("Total bill: " + consultationFee);
    }
    public void AddRecord()
    {
        Console.WriteLine("Record added successfully");
    }
    public void ViewRecord()
    {
        Console.WriteLine("Record viewed successfully");
    }
}

public class Program
{
    public static void Main()
    {
        InPatient inPatient = new InPatient(101, "John", 25, "101", "A1", 1000);
        inPatient.GetPatientDetails();
        inPatient.CalculateBill();
        inPatient.AddRecord();
        inPatient.ViewRecord();
        OutPatient outPatient = new OutPatient(102, "Jane", 30, "Dr. Smith", 500);
        outPatient.GetPatientDetails();
        outPatient.CalculateBill();
        outPatient.AddRecord();
        outPatient.ViewRecord();
    }
}
