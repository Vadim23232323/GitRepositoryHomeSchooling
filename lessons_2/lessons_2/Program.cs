using System;

namespace lessons_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num_1 ;
            
            //Типы переменных
            //uint num_1 = 10;
            //float f = 1.23f;
            //bool boolean = false;
            //string text = "Work";
            //char n = 'W';

            Console.WriteLine("Enter first num: ");
            num = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("\nEnter first num_1: ");
            num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe result is: " + (num + num_1).ToString());
            Console.ReadKey();
        }
    }
}
