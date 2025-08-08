using System;

namespace OOPAssignment
{
    // Interface
    public interface IMovable
    {
        void Move();
    }

    // Implementing class
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Another implementing class
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}