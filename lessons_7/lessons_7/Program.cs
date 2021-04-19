using System;

namespace lessons_7
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = {1.23f, 23.23f, 23.57f};

            foreach (var el in numbers)
            {
                Console.WriteLine(el);
            }
            
            Console.ReadKey();
        }
    }
}
