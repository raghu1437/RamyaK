using System;

namespace PublicAM
{

    class Student
    {
        public int rollno;
      internal protected string name;
        
        public Student(int r, string n)
        {
            rollno = r;
            name= n;
        }

       public int getRollNo()
        {
            return rollno;

        }

        public string getName()
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student(1, "Ram");
            Console.WriteLine("rollno:{0} name:{1}", S.rollno,S.name);

            Console.WriteLine("RollNo is {0 }", S.getRollNo());
            Console.WriteLine("Name is {0}", S.getName());

        }
    }
}
