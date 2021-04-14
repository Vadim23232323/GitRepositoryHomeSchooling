using System;

namespace lessons_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double age;
            Console.WriteLine("How old are you?");
            age = Convert.ToDouble(Console.ReadLine());

            if (age > 18 && age < 23)
                Console.WriteLine("age match");
            else
                Console.WriteLine("age does not match");

            string name = age == 15 ? "first" : "second";
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
