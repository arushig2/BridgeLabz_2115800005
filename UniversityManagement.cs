//using System;

//public class Student
//{
//    public static string universityName = "GLA University";
//    public static int totalStudents = 0;
//    public string name;
//    public string grade;
//    public readonly int rollNo;


//    public Student()
//    {
//        totalStudents++;
//    }

//    public Student(string name, int rollNo, string grade)
//    {
//        this.name = name;
//        this.rollNo = rollNo;
//        this.grade = grade;

//    }

//    public static void DisplayTotalStudents()
//    {
//        Console.WriteLine($"Total Students : {totalStudents}");
//    }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"University Name: {universityName}");
//        Console.WriteLine($"Student Name: {name}");
//        Console.WriteLine($"Student Roll No.: {rollNo}");
//        Console.WriteLine($"Grade: {grade}");
        
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        object obj1 = new Student("Ravi", 2, "A");
//        object obj2 = new Student("Rishi", 3, "C");
//        object obj3 = "Not an Student";

//        if (obj1 is Student student1)
//        {
//            student1.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj1 is not an instance of Student.");
//        }

      

//        if (obj2 is Student student2)
//        {
//            student2.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj2 is not an instance of Student.");
//        }


//        Student.DisplayTotalStudents();
//        if (obj3 is Student student3)
//        {
//            student3.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj3 is not an instance of Student.");
//        }

//    }
//}
