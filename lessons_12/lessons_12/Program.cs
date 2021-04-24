using System;

namespace lessons_12
{
    class Student
    {
        public static int count = 0;
        public string name;
        public int age;
        public int course;
        public bool grants;


        public int Course
        {
            get
            {
                return course;

            }
            set
            {
                if (value < 1)
                    course = 1;
                else if (value > 5)
                    course = 5;
                else
                    course = value;
                }
        }

        public Student ()
        {
        name="Maksim";
        age=19;
        course=2;
        grants=true;
        count++;
        Print();
        }

        public Student (string name, int age, int course, bool grants)
        {
            this.name = name;
            this.age = age;
            this.course = course;
            this.grants = grants;
            count++;
            Print();
        }

        public void Print ()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Grants: " + grants);
        }

    }
    
    class Animal
    {
         public static int count = 0;
         public string name ;
         public int age;
         public float hapiness;

         public Animal ()
         {
             name = "tady";
             age = 7;
             hapiness = 0.6f;
             count++;
             Print();
         }

         public Animal (string _name, int _age, float _hapiness)
         {
             name = _name;
             age = _age;
             hapiness =_hapiness;
             count++;
             Print();
         }
        public void Print()
         {
             Console.WriteLine("Name " + name);
             Console.WriteLine("Age " + age);
             Console.WriteLine("Hapiness " + hapiness);
        }

    }
class Program
    {
        static void Main(string[] args)
        {
            //Animal cat = new Animal();
            //Console.WriteLine();
            //Animal dog = new Animal("Tom", 12, 0.99f);
            //Console.WriteLine("Count of animals: " + Animal.count);
            //Console.ReadKey();

            Student One = new Student();
            One.course = 3;
            Console.WriteLine(One.Course);
            Console.WriteLine("Enter name student");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter age student");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter course student");
            int course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter grants student");
            bool grants = Convert.ToBoolean(Console.ReadLine());
            Student Two = new Student(name,age,course,grants);
            Console.WriteLine("Count of students: " + Student.count);
            Console.ReadKey();
        }
    }
}
