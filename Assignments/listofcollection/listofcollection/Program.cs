using System;
using System.Linq;
using System.Collections.Generic;


namespace listofcollection
{
    class Program
    {
        static bool checkstring(string str)
        {
            if (str.Length < 5)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            List<string> Student = new List<string>();

            Student.Add("ram");
            Student.Add("Naren");
            Student.Add("Asha");
            Student.Add("ramya");
            Student.Add("seetha");
            Student.Add("sam");

            IEnumerable<string> result = Student.Where(stud => checkstring(stud));

            foreach(var res in result)
            {
                Console.WriteLine(res);
            }
         }
    }

            

    
}
