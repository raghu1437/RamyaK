using System;

namespace Smallest_No_in_an_array
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int i = 0;
            int small;

            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter the list of nos. in an array : Element([" + (i + 0) + "] :");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            small = numbers[0];
            for (i = 0; i < numbers.Length; i++)
            {
                if (small > numbers[i])
                    small = numbers[i];

            }
            Console.WriteLine("Smallest no. in the array is :{0}", small);
        }
    }
}
