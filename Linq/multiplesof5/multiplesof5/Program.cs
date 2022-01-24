using System;
using System.Linq;
using System.Collections.Generic;

namespace multiplesof5
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> multiple = ((ParallelQuery<int>)ParallelEnumerable.Range(2, 30))
                .Where(x => x % 5 == 0)
                .Select(y => y);
            foreach(int res in multiple)
            {
                Console.WriteLine(res);
            }
        }
    }
}
