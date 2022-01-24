using System;

namespace median
{
    class Program
    {
        
        static void Main(string[] args)
        {
            float median, temp;
            int[] numbers = new int[8];
            int i, j;


            for ( i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element [" + (i + 0) + "]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            temp = 0;
            
            for ( i = 0; i < ((numbers.Length) - 1); i++)
            {
                for (j = 0; j < (numbers.Length) - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }


        }
    }
}
