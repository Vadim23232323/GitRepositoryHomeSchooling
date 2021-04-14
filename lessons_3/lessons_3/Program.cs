using System;

namespace lessons_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("How old are you?");
            num = Convert.ToDouble(Console.ReadLine());

            if (num > 18.23d && num <25.34d)
                Console.WriteLine("You are older than 18.23");
            else
                Console.WriteLine("Else");

            string name = num == 15 ? "First" : "Second";
            Console.WriteLine(name);
            
            Console.ReadKey();
        }
    }
}
