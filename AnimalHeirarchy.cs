using System;

public class Animal
{
    public string Name;
    public int Age;

    public Animal(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public Dog(string Name, int Age) : base(Name, Age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks!");
    }
}

public class Cat : Animal
{

    public Cat(string Name, int Age) : base(Name, Age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Cat Meows!");
    }
}

public class Bird : Animal
{
    public Bird(string Name, int Age) : base(Name, Age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bird Chirps!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal("Animal", 0);
        animal.MakeSound();

        Dog dog = new Dog("Dog", 1);
        dog.MakeSound();

        Cat cat = new Cat("Cat", 2);
        cat.MakeSound();

        Bird bird = new Bird("Bird", 3);
        bird.MakeSound();
    }
}

