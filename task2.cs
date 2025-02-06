// using System;

// class Parent1
// {
	// public string name;
	// protected int id;

	// public Parent1()
	// {

	// }

	// public Parent1(string name, int id)
	// {
		// this.name = name;
		// this.id = id;
	// }

	// public void DisplayParent1()
	// {
		// Console.WriteLine("This is parent 1 method");
		// Console.WriteLine($"Name: {name}");
		// Console.WriteLine($"ID: {id}");
	// }
// }

// class Child1 : Parent1
// {
	// public int age;

	// public Child1(string name, int id, int age) : base(name, id)
	// {
		// this.age = age;
	// }

    // public void DisplayChild1()
    // {
        // Console.WriteLine("This is child 1 method");
        // Console.WriteLine($"Name: {name}");
        // Console.WriteLine($"ID: {id}");
		// Console.WriteLine($"Age: {age}");
    // }

// }

// class Child2 : Child1
// {
	// public string gender;

	// public Child2(string name, int id, int age, string gender) : base(name, id, age)
	// {
		// this.gender = gender;
	// }

    // public void DisplayChild2()
    // {
        // Console.WriteLine("This is child 2 method");
        // Console.WriteLine($"Name: {name}");
        // Console.WriteLine($"ID: {id}");
        // Console.WriteLine($"Age: {age}");
		// Console.WriteLine($"Gender: {gender}");
    // }

// }

// public class Task2
// {
	// public static void Main(string[] args)
	// {
		// Parent1 parent = new Parent1("Raj", 1);
		// parent.DisplayParent1();

		// Child1 child = new Child1("Ravi", 2, 23);
		// child.DisplayChild1();
		// child.DisplayParent1();

		// Child2 child2 = new Child2("Rishi", 3, 34, "MALE");
		// child2.DisplayChild2();
		// child2.DisplayChild1();
		// child2.DisplayParent1();

	// }
// }




	