using System;

public class Course
{
    public string courseName;
    public int courseDuration;

    public Course(string courseName, int courseDuration)
    {
        this.courseName = courseName;
        this.courseDuration = courseDuration;

    }
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Course Duration: " + courseDuration);

    }
}

public class OnlineCourse : Course
{
    public string platform;
    public bool isRecorded;

    public OnlineCourse(string courseName, int courseDuration, string platform, bool isRecorded) : base(courseName, courseDuration)
    {
        this.platform = platform;
        this.isRecorded = isRecorded;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("Online Course Details: ");
        base.DisplayCourseDetails();
        Console.WriteLine("Platform: " + platform);
        Console.WriteLine("Is Recorded?: " + isRecorded);
    }
}

public class PaidOnlineCourse : OnlineCourse
{
    public double fee;
    public double discount;

    public PaidOnlineCourse(string courseName, int courseDuration, string platform, bool isRecorded, double fee, double discount) : base(courseName, courseDuration, platform, isRecorded)
    {
        this.fee = fee;
        this.discount = discount;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("Paid Online Course Details: ");
        base.DisplayCourseDetails();
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Discount: " + discount);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Course course = new Course("C#", 30);
        course.DisplayCourseDetails();

        Console.WriteLine();

        OnlineCourse onlineCourse = new OnlineCourse("Java", 40, "Coursera", true);
        onlineCourse.DisplayCourseDetails();

        Console.WriteLine();

        PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Python", 50, "Udemy", true, 100, 10);
        paidOnlineCourse.DisplayCourseDetails();
    }
}