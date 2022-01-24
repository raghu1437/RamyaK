using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>()
            {"mumbai", "pune", "bangalore", "hyderabad"};

            var Querysyntax = (from C in cities
                               select C).Reverse();
            foreach (var city in Querysyntax)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("*******************************");


            var methodsyntax = cities.AsEnumerable().Reverse();
            foreach (var C in methodsyntax)
            {
                Console.WriteLine(C);
            }

        }
    }

   
}
