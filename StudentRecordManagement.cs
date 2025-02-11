using System;

public class Student
{
    public int rollNo;
    public string name;
    public int age;
    public string grade;
    public Student next;

    public Student()
    {
        this.rollNo = 0;
        this.name = "";
        this.age = 0;
        this.grade = "";
        this.next = null;
    }

    public Student(int rollNo, string name, int age, string grade)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.age = age;
        this.grade = grade;
        this.next = null;
    }
}

public class StudentList
{
    private Student head;

    public void AddStudentAtBeginning(Student newStudent)
    {
        newStudent.next = head;
        head = newStudent;
        Console.WriteLine("Student added successfully");
    }

    public void AddStudentAtEnd(Student newStudent)
    {
        if (head == null)
        {
            head = newStudent;
        }
        else
        {
            Student temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newStudent;
        }
        Console.WriteLine("Student added successfully");
    }

    public void AddStudentAtPosition(Student newStudent, int position)
    {
        if (position == 1)
        {
            newStudent.next = head;
            head = newStudent;
        }
        else
        {
            Student temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.next;
            }
            newStudent.next = temp.next;
            temp.next = newStudent;
        }
        Console.WriteLine("Student added successfully");
    }

    public void DeleteStudentByRollNo(int rollNo)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }
        else if (head.rollNo == rollNo)
        {
            head = head.next;
        }
        else
        {
            Student temp = head;
            while (temp.next != null && temp.next.rollNo != rollNo)
            {
                temp = temp.next;
            }
            if (temp.next == null)
            {
                Console.WriteLine("Student with roll number " + rollNo + " not found");
            }
            else
            {
                temp.next = temp.next.next;
            }
        }
        Console.WriteLine("Student deleted successfully");

    }

    public void SearchStudentByRollNo(int rollno)
    {
        Student temp = head;
        while (temp != null && temp.rollNo != rollno)
        {
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("Student with roll number " + rollno + " not found");
        }
        else
        {
            Console.WriteLine("Student found with roll number " + rollno);
            Console.WriteLine("Name: " + temp.name);
            Console.WriteLine("Age: " + temp.age);
            Console.WriteLine("Grade: " + temp.grade);
        }
    }

    public void UpdateGradeByRollNo(int rollNo, string grade)
    {
        Student temp = head;
        while (temp != null && temp.rollNo != rollNo)
        {
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("Student with roll number " + rollNo + " not found");
        }
        else
        {
            temp.grade = grade;
            Console.WriteLine("Grade updated successfully");
        }
    }

    public void DisplayStudentList()
    {
        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine("Roll No: " + temp.rollNo);
            Console.WriteLine("Name: " + temp.name);
            Console.WriteLine("Age: " + temp.age);
            Console.WriteLine("Grade: " + temp.grade);
            Console.WriteLine();
            temp = temp.next;
        }
    }
}

public class Program
{
    public static void Main()
    {
        StudentList studentList = new StudentList();
        Student student1 = new Student(1, "Alice", 20, "A");
        Student student2 = new Student(2, "Bob", 21, "B");
        Student student3 = new Student(3, "Charlie", 22, "C");
        Student student4 = new Student(4, "David", 23, "D");
        Student student5 = new Student(5, "Eve", 24, "E");
        studentList.AddStudentAtBeginning(student1);
        studentList.AddStudentAtEnd(student2);
        studentList.AddStudentAtEnd(student3);
        studentList.AddStudentAtEnd(student4);
        studentList.AddStudentAtEnd(student5);
        studentList.DisplayStudentList();

        studentList.DeleteStudentByRollNo(3);
        studentList.DisplayStudentList();

        studentList.SearchStudentByRollNo(2);

        studentList.UpdateGradeByRollNo(4, "A");
        studentList.DisplayStudentList();
    }
}



