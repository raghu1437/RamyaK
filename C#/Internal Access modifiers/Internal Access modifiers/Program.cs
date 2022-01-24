using System;

namespace Internal_Access_modifiers
{

        class User
        {
            internal string Name;
            internal string Location;
            internal int Age;
            internal void GetUserDetails()
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
                u.Name = "Suresh Dasari";
                u.Name = "Suresh Dasari";
                u.Location = "Hyderabad";
                u.Age = 32;
                u.GetUserDetails();
                Console.WriteLine("\nPress Enter Key to Exit..");
                Console.ReadLine();
            }
        }
    }

//In c#, the internal modifier is used to specify that access is limited to the current assembly.
//The type or member can be accessed by any code in the same assembly but not from another assembly.