using System;

interface IAnimal
{
    void MakeSound();

    void Sleep()
    {
        Console.WriteLine("Sleeping... (Default in Interface)");
    }
}

class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }

    // Overriding default method
    public void Sleep()
    {
        Console.WriteLine("Cat is sleeping differently...");
    }
}

class Program
{
    static void Main()
    {
        Cat cat = new Cat();
        cat.MakeSound();  
        cat.Sleep();      
    }
}
