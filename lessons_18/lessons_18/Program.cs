using System;

namespace lessons_18
{
    class Some
    {
        public void Multiplay(int a, int b)
        {
            Console.WriteLine("Result - " + a*b);
        }

        public void Multiplay(int a, int b, int c)
        {
            Console.WriteLine("Result - " + a * b * c);
        }
        public string Multiplay(string str)
        {
            Console.WriteLine("Result - " + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Some test = new Some();
            test.Multiplay(2,2);
            test.Multiplay(2, 2, 4);
            test.Multiplay("some test");
            Console.ReadKey();
        }
    }
}
