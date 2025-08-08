using System;
using OOPAssignment;

class Program
{
    static void Main(string[] args)
    {
    
        Animal genericAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        Console.WriteLine("Part 1: Inheritance and Method Overriding");
        genericAnimal.MakeSound();
        myDog.MakeSound();
        myCat.MakeSound();
        Console.WriteLine();
    }
}