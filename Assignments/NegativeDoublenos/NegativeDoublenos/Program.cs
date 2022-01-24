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
                7,6,-1.0,-2.45,-3.14,0.19,-2.8,3.9,10,9,8

            };

            //var querysyntax = (from obj in Objects
            //                   where obj is double && obj < 0
            //                   select obj).ToList();

            //foreach (var res in querysyntax)
            //{
            //    Console.WriteLine(res);
            //}
            //Console.WriteLine("*********************");

            var methodsyntax = Objects.OfType<double>().Where(obj => obj < 0).ToList();
            foreach (var result in methodsyntax)
            {
                Console.WriteLine(result);
            }



        }
    }
}
