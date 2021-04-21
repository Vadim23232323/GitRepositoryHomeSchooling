using System;

namespace lessons_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_1, num_2, result;
            OneMetod("HI");
            num_1 = Convert.ToInt32(Console.ReadLine());
            num_2 = Convert.ToInt32(Console.ReadLine());
            result=Add(num_1,num_2);
            Console.WriteLine("Result is - " + result);
            Console.ReadKey();

        }

        static void OneMetod(string str)
        {
            Console.WriteLine(str);
        }

        static int Add(int num_1, int num_2)
        {
            return num_1 + num_2;
            
        }
    }
}
