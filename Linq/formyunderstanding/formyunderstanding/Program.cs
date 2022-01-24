using System;
using System.Linq;
    using System.Collections.Generic;

namespace formyunderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> numbers = new List<int> {0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("******evennos.*******");
            var result = from L in numbers
                         where (L % 2 == 0)
                         select L;

            foreach (var res in result)
            {
                Console.WriteLine(res);
                
            }

            Console.WriteLine("*******positive nos.*******");
            var result1 = from No in numbers
                          where (No > 0 && No < 9)
                          select No;

            foreach(var res1 in result1)
            {
               
                Console.WriteLine(res1);
            }

            Console.WriteLine("*********Squareofnos.*********");

            var result2 = (from int num in numbers
                           let sqrno = num * num
                           where sqrno > 10
                           select new { num, sqrno });
            foreach(var res2 in result2)
            {
                Console.WriteLine(res2);
            }

            List<string> strings = new List<string> { "A", "Ball", "Cat" };
           IEnumerable<string> whatsThis = from str in strings
                               where str.First(val => str.Take(val))
                               select str;




    }
}
