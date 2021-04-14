using System;

namespace lessons_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();

            int num;
            Console.WriteLine("How old are you?");
            num = randNum.Next(0, 6);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Resultat " + num);
                    break;
                case 2:
                    Console.WriteLine("Resultat " + num);
                    break;
                case 3:
                    Console.WriteLine("Resultat " + num);
                    break;
                case 4:
                    Console.WriteLine("Resultat " + num);
                    break;
                case 5:
                    Console.WriteLine("Resultat " + num);
                    break;
                default:
                    Console.WriteLine("Nothing " + num);
                    break;
            }

            Console.ReadKey();
        }
    }
}
