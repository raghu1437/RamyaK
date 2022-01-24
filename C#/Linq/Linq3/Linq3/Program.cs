using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> lists= new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var querySyntax = from L in lists
                              where L > 2
                              select L;

            foreach(var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************************/n");

            IEnumerable<int> methodSyntax = lists.Where(L => L > 2);

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            var methodSyntax1 = lists.Where(L => L < 4);
            foreach(var item in methodSyntax1)
            {
                Console.WriteLine(item);
            }

            var querySyntax1 = from Li in lists
                              where (Li > 2)
                              select Li;

            foreach (var res in querySyntax)
            {
                Console.WriteLine(res);
                    }
        }
    }


}
