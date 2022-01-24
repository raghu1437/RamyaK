using System;
using System.Linq;
using System.Collections.Generic;

namespace stringcomparer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Studentise = new List<string>()
            {
                "Ramya","Asha","mahesh","Naren"

            };
            List<string> Studentcse = new List<string>()
            {
                "Ramya","Asha","Prakash","Sunil"

            };
            var res = Studentise.Union(Studentcse, StringComparer.OrdinalIgnoreCase);
            foreach(var r in res)
            {
                Console.WriteLine(r);

            }
        }
    }
    
    
}
