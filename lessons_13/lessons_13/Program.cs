using System;

namespace lessons_13
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

        public Dog(float speed, string name) : base (name)
        {
            this.speed = speed;
            Console.WriteLine("Speed " +speed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog tom =new Dog(13.3f, "Tom");
            Console.WriteLine(tom.Name);
            
            Dog tady = new Dog(23.3f, "Tady");
            Console.WriteLine(tady.Name);
            Console.WriteLine();
            tady.Print();

            Console.ReadKey();
        }
    }
}
