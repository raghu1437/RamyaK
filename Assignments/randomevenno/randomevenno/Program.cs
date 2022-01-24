using System;
using System.Collections.Generic;
using System.Linq;

namespace randomevenno
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> even = ((ParallelQuery<int>)ParallelEnumerable.Range(26, 15))
                .Where(y => y % 2 == 0)
                .Select(x => x);
            foreach(int e in even)
            {
                Console.WriteLine(e);
            }
        }
    }
}
