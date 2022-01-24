using System;

namespace reversinganarray
{
    class Program
    {
       
        static void Main()
        {

            int low;
            int high;
            int[] numbers = new int[3];
            int n = numbers.Length;
            for (int i= 0;i < n;i++)
            {
                Console.WriteLine("Element[" + (i + 0) + "] : ");
                numbers[i] = int.Parse(Console.ReadLine());

            }
            for (low=0, high = n - 1; low < high;low++,high--)
            {
                int temp = numbers[low];
                numbers[low] = numbers[high];
                numbers[high] = temp;
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" {0} " , numbers[i]);
                    
                }
                
            }

            
        }
    }
}
