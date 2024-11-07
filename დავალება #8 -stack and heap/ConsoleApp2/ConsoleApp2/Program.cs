
using System;

namespace PersonApp
{
    class Program
    {
        static void Main()
        {
           
            string name = "Sesili";
            int age = 13;

            Person person1 = new Person
            {
                Name = name,
                Age = age
            };

            Console.WriteLine("pirveli");
            Console.WriteLine("Name: " + person1.Name);
            Console.WriteLine("Age: " + person1.Age);

            Person person2 = person1;
            person2.Name = "Anna";
            person2.Age = 8;

          
            Console.WriteLine("meore");
            Console.WriteLine("Name: " + person2.Name);
            Console.WriteLine("Age: " + person2.Age);


        }
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

