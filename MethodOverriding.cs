using System;

class Animal
{

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}


class Dog : Animal
{

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof! Woof!");
    }
}

class Program
{
    static void Main()
    {

        Dog myDog = new Dog();
        myDog.MakeSound();
    }
}
