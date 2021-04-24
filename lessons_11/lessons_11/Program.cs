using System;

namespace lessons_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Num is " + num);
            }
            catch (FormatException) {
                Console.WriteLine("Format exception");
            }
            

            Console.ReadKey();
        }
    }
}
