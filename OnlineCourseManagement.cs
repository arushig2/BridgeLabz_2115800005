using System;

public class Course
{
   private string courseName;
   private int duration;
   private double fee;
   private static string instituteName = "GLA University";

   public string CourseName
   {
       get { return courseName; }
       set { courseName = value; }
   }

   public int Duration
   {
       get { return duration; }
       set { duration = value; }
   }

   public double Fee
   {
       get { return fee; }
       set { fee = value; }
   }

   public Course()
	{
	}

   public Course(string courseName, int duration, double fee)
   {
       this.courseName = courseName;
       this.duration = duration;
       this.fee = fee;
   }

   public void DisplayCourseDetails()
   {
       Console.WriteLine($"Course Name: {courseName}");
       Console.WriteLine($"Duration in Months: {duration}");
       Console.WriteLine($"Fee: {fee}");
       Console.WriteLine($"Institute Name: {instituteName}");
   }

   public static void UpdateInstituteName(string newName)
   {
       instituteName = newName;
   }
}

class Program
{
   public static void Main(string[] args)
   {
       Course course1 = new Course("Machine Learning", 2, 1000);
       course1.DisplayCourseDetails();

       Course.UpdateInstituteName("GLA University, Mathura");
       course1.DisplayCourseDetails();
   }
}
