using System;

interface IAnimal
{
    string MakeSound();
}

abstract class Animal : IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

   
    public abstract string MakeSound();
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

   
    public override string MakeSound()
    {
        return "Woof";
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    
    public override string MakeSound()
    {
        return "Meow";
    }
}

class Cow : Animal
{
    public Cow(string name, int age) : base(name, age) { }

    
    public override string MakeSound()
    {
        return "Moo";
    }
}

class Program
{
    static void Main()
    {

        IAnimal[] animals = new IAnimal[]
        {
            new Dog("Jina", 3),
            new Cat("Chiko", 2),
            new Cow("Wikara", 5)
        };


        foreach (IAnimal animal in animals)
        {
            Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
        }
    }
}

