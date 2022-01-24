using System;
using System.Collections.Generic;
using System.Linq;

namespace sortint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> Objects = new List<object>()
            {
                "raju", 345, 18.0 , "mohan", 189, 193, 30, 200, "rajesh"

            };

            var querysyntax = (from obj in Objects
                               where obj is int
                               orderby obj
                               select obj).ToList();

            foreach(var res in querysyntax)
            {
                Console.WriteLine(res);
            }
            Console.WriteLine("*********************");

            var methodsyntax = Objects.OfType<int>().OrderBy(obj => obj).ToList();
            foreach (var result in methodsyntax)
            {
                Console.WriteLine(result);
            }

           
            
        }
    }
}
