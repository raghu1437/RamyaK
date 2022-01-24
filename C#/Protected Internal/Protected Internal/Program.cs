using System;

namespace Protected_Internal
{
    class User
    {
        protected internal string Name;
        protected internal string Location;
        protected internal int Age;
        protected internal void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Ramyai";
            u.Location = "Bangalore";
            u.Age = 32;
            u.GetUserDetails();
           
        }
    }
}
