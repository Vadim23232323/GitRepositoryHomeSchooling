using System;
using System.Collections.Generic;

namespace lessons_16
{
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Print();

    }

    class Dog : Animal
    {
        public float speed;

        public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;
        }

        public override void Print()
        {
            Console.WriteLine("Dog Speed: " + speed);
        }
    }

    class Cat : Animal
    {
        public float speed;

        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
        }
        public override void Print()
        {
            Console.WriteLine("Cat Speed: " + speed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(30, "homa"));
            animals.Add(new Dog(10, "Charep"));
            animals.Add(new Cat(100, "Tady"));

            foreach (Animal animal in animals)
            {
                animal.Print();
            }

            Console.ReadKey();
        }
    }
}
