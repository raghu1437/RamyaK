using System;

namespace Sortingof_strings
{
    class Program
    {
        
        static void Main()
        {
            String[] Names = new string[5];
            for (int i=0;i<Names.Length;i++)
            {
                Console.WriteLine("Enter the Names in the Array ", Names[i]);
                Names[i] = Console.ReadLine();
            }
            Array.Sort(Names);
            foreach (string x in Names)
            {
                Console.WriteLine("Sorted Elements are :{0}",x);
            }

        }
    }
}
