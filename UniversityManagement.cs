using System;
using System.Collections.Generic;

abstract class CourseType
{
    public string EvaluationMethod { get; set; }

    protected CourseType(string method)
    {
        EvaluationMethod = method;
    }

    public abstract void DescribeEvaluation();
}

class ExamCourse : CourseType
{
    public ExamCourse() : base("Final Exam") { }

    public override void DescribeEvaluation()
    {
        Console.WriteLine($"This course is evaluated based on a {EvaluationMethod}.");
    }
}

class AssignmentCourse : CourseType
{
    public AssignmentCourse() : base("Assignments & Projects") { }

    public override void DescribeEvaluation()
    {
        Console.WriteLine($"This course is evaluated based on {EvaluationMethod}.");
    }
}

class Course<T> where T : CourseType
{
    public string CourseName { get; set; }
    public string Department { get; set; }
    public T Evaluation { get; set; }

    public Course(string name, string department, T evaluation)
    {
        CourseName = name;
        Department = department;
        Evaluation = evaluation;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"{Department} - {CourseName}");
        Evaluation.DescribeEvaluation();
    }
}

class University
{
    private List<BaseCourse> courses = new List<BaseCourse>();

    public void AddCourse<T>(Course<T> course) where T : CourseType
    {
        courses.Add(new BaseCourse(course.CourseName, course.Department, course.Evaluation));
    }

    public void DisplayAllCourses()
    {
        Console.WriteLine("\nUniversity Courses:");
        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Department} - {course.CourseName}");
            course.Evaluation.DescribeEvaluation();
        }
    }
}

class BaseCourse
{
    public string CourseName { get; }
    public string Department { get; }
    public CourseType Evaluation { get; }

    public BaseCourse(string name, string department, CourseType evaluation)
    {
        CourseName = name;
        Department = department;
        Evaluation = evaluation;
    }
}

class Program
{
    static void Main()
    {
        University university = new University();

        var csCourse = new Course<ExamCourse>("Data Structures", "Computer Science", new ExamCourse());
        var mathCourse = new Course<AssignmentCourse>("Linear Algebra", "Mathematics", new AssignmentCourse());

        university.AddCourse(csCourse);
        university.AddCourse(mathCourse);

        university.DisplayAllCourses();
    }
}
