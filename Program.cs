using System;
using OOPAssignment;

class Program
{
    static void Main(string[] args)
    {
        //Part 1
        Animal genericAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        Console.WriteLine("Part 1: Inheritance and Method Overriding");
        genericAnimal.MakeSound();
        myDog.MakeSound();
        myCat.MakeSound();
        Console.WriteLine();


        // Part 2
        Circle myCircle = new Circle(5);
        Rectangle myRectangle = new Rectangle(4, 6);

        Console.WriteLine("Part 2: Abstract Classes and Methods");
        Console.WriteLine($"Circle area: {myCircle.GetArea()}");
        Console.WriteLine($"Rectangle area: {myRectangle.GetArea()}");
        Console.WriteLine();


        // Part 3
        Car myCar = new Car();
        Bicycle myBicycle = new Bicycle();

        Console.WriteLine("Part 3: Interfaces");
        myCar.Move();
        myBicycle.Move();
    }
}