using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseCities
{

    public static class Program
    {
        static void Main(String[] args)
        {
          List <string> Cities =  new List<string>{ "mumbai", "pune", "bangalore", "hyderabad" };

            var querysyntax = (from city in Cities
                               select city).Reverse();
            foreach(var res in querysyntax)
            {
                Console.WriteLine(res);
            }

            Console.WriteLine("*************************************");

            var methodsyntax = Cities.AsEnumerable().Reverse();
            foreach(var result in methodsyntax)
            {
                Console.WriteLine(result);
            }
        }
    }
}
