using System;

namespace Access_Modifiers
{


    class Student
    {
        public string name;
        public int rollNo;


        public Student(int r, string n)
        {
           rollNo = r;
            name = n;

        }
      internal int getRollNo()
        {
            return rollNo;

        }

        private string getName()
        {
            return name;
        }
    }
    
   
    class Program 
    {
               
        static void Main(string[] args)
        {
            Student S = new Student(101, "Ramya");
            Console.WriteLine("Roll Number:{0}", S.rollNo);
            Console.WriteLine("Name:{0}", S.name);

            Console.WriteLine();
            Console.WriteLine("Roll Number:{0}", S.getRollNo());
            Console.WriteLine("Name:{0}", S.getName());

        }
    }
}

