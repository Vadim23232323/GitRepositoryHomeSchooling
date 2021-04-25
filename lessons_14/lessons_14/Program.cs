using System;
using System.Collections.Generic;

namespace lessons_14
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Dog : Animal
    {
        public float speed;

        public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;
        }
    }

    class Cat : Animal
    {
        public float speed;

        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
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
                if (animal is Cat)
                Console.WriteLine(animal.Name);
                if (animal is Cat)
                    (animal as Cat).Print();
            }

            Console.ReadKey();
        }
    }
}
