using System;

namespace lessons_20
{
    struct Book
    {
        public string title;
        public string name;
        public string author;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Books");
            Book b;
            b.author = "king";
            Console.ReadKey();
        }
    }
}
