using System;
using System.Collections.Generic;
using System.Globalization;

namespace lessons_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, m;
            Random ranelement = new Random();

            List<int> car = new List<int>();

            car.Add(7);
            car.Add(4);

        

            Console.WriteLine(car[]);

            //Двумерный массив
            //Console.WriteLine("Заполните размерность масива n на m");
            //Console.WriteLine("Введите n ");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите m ");
            //m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\nРазмер массива n x m");
           
            //int [,] array = new int[n, m];
            //for (i = 0; i < n; i++)
            //{ 
            //    for (j =0; j < m; j++)
            //    {
            //        array[i, j] = ranelement.Next(2,10);
            //        Console.WriteLine("{0}\t", array[i,j]);
                  
            //    }
            //    Console.WriteLine();
            //}



            Console.ReadKey();
        }
    }
}
