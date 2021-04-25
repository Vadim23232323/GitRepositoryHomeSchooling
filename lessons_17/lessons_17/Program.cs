using System;

namespace lessons_17
{
    interface ISomeInterface 
    {
        int property { get; set; }
        void Print();
    }

    interface IDraw
    {
        void Draw();
    }

    class Test : ISomeInterface, IDraw
    {
        public int property { get; set; }

        public void Print()
        {
            Console.WriteLine("Some text");
        }

        public void Draw()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }

    class Test_2: ISomeInterface
    {
        public int property { get; set; }

        public void Print()
        {
            Console.WriteLine("Some text 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test test = new Test();
            Test_2 test_2 = new Test_2();
            test.property = 2;
            test.Print();
            test.Draw();
            Console.WriteLine(test.property);

            Console.WriteLine("________________________________________________________");

            test_2.property = 6;
            test_2.Print();
            Console.WriteLine(test_2.property);
            Console.ReadKey();
        }
    }
}
