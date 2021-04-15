using System;

namespace lessons_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, number=1;

            for (i = 10; i >= 5; i--)
            {
                if (i==8)
                    break;
                Console.WriteLine(i + "\n");
            }

            //while (i<=10)
            //{
            //    Console.WriteLine(i + "\n");
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("Enter number:");
            //    number = Convert.ToInt32(Console.ReadLine());
            //} while (number != 5);

            Console.ReadKey();
        }
    }
}
