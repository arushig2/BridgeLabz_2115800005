using System;

public class Person
{
	private string name;
	private int age;
	private int id;

   public string Name
   {
       get { return name; }  // Getter
       set { name = value; } // Setter
   }

   public int Age
   {
       get { return age; } //getter
       set { age = value; } //setter
   }

   public int Id
	{
		get { return id; } //getter
		set { id = value; } //setter
	}

   public Person() //default constructor
	{
		name = string.Empty;
		age = 0;
		id = 0;
	}

	public Person(string name, int age, int id) //parametrized constructor
	{
		this.name = name;
		this.age = age;
		this.id = id;
	}

	public Person(Person person) //copy constructor
	{
		this.name = person.name;
		this.age = person.age;
		this.id = person.id;
	}

	public void DisplayDetails()
	{
		Console.WriteLine($"Name: {name}");
		Console.WriteLine($"Age: {age}");
		Console.WriteLine($"ID: {id}");
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Person person1 = new Person();
		person1.Name = "raj";
		person1.Age = 20;
		person1.Id = 1;

		Person person2 = new Person("rahul", 22, 2);
		Person person3 = new Person(person2);

		person1.DisplayDetails();
		person2.DisplayDetails();
		person3.DisplayDetails();
	}
}
