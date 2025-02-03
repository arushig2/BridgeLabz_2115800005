using System;

public class Student
{
	public int rollNo;
	protected  string name;
	private double cgpa;

	public double GetCGPA()
	{
		return cgpa;
	}

	public void SetCGPA(double newCGPA)
	{
		cgpa = newCGPA;
	}

	public Student()
	{
	}

	public Student(int rollNo, string name, double cgpa)
	{
		this.rollNo = rollNo;
		this.name = name;
		this.cgpa = cgpa;
	}

	public void DisplayStudentDetails()
	{
       Console.WriteLine("Student Details: ");
       Console.WriteLine($"Name: {name}");
		Console.WriteLine($"Roll No.: {rollNo}");
	}
}

public class PostgraduateStudent : Student
{
	public string course;

	public PostgraduateStudent(int rollNo, string name, double cgpa, string course) : base(rollNo, name, cgpa) {
		this.course = course;
	}

	public void DisplayInfo()
	{
		Console.WriteLine("PostGraduate Student Details: ");
		DisplayStudentDetails();
       Console.WriteLine($"Course: {course}");
		Console.WriteLine($"CGPA: {GetCGPA()}"); //display cgpa using GetCGPA as it is private member of student class
	}

}

public class Program
{
	public static void Main(string[] args)
	{

		Student student = new Student(1,"Ravi", 8.9);
		student.DisplayStudentDetails();
		Console.WriteLine($"CGPA: {student.GetCGPA()}"); //use GetCgpa to acceess cgpa (private member)
		student.SetCGPA(7.8); //use SetCGPA function to update cgpa
		student.DisplayStudentDetails();
		Console.WriteLine($"CGPA: {student.GetCGPA()}");

       PostgraduateStudent pg1 = new PostgraduateStudent(2, "raj", 9.0, "Machine learning"); //create object of subclass
		pg1.DisplayInfo(); //postgraduate method
		pg1.SetCGPA(8.0); //set cgpa using function of student class
		pg1.DisplayStudentDetails(); //object of subclass call method of base class
		Console.WriteLine($"CGPA: {pg1.GetCGPA()}");


	}
}
