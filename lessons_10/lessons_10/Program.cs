using System;

namespace lessons_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello, world, maks";
            Console.WriteLine(string.IsNullOrEmpty(str));
            Console.WriteLine(string.IsNullOrWhiteSpace(str));

            String.Compare("rttr", "b"); 

            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Contains("hel"));
            Console.WriteLine(str.StartsWith("hel"));
            Console.WriteLine(str.EndsWith("hel"));
            Console.WriteLine(str.Insert(5," world"));
            Console.WriteLine(str.Remove(3));
            char[] sym = str.ToCharArray();
            string[] clubs = str.Split (',');
            Console.WriteLine(clubs[2]);
            Console.ReadKey();
        }
    }
}
