using System;
using System.Collections.Generic;
using System.Linq;

namespace parallelquerytooddnos
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable <int> odd = ((ParallelQuery<int>) ParallelEnumerable.Range(10, 11))
                .Where(y => y % 2 != 0)
                 .Select(j => j);
            foreach (int n in odd)
            {
                Console.WriteLine(n);
            }

        }
    }
}
