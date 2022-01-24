using System;

namespace Findinggreatestno_
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int large = 0;
            int[] number = new int[7];
            
            Console.WriteLine("Enter the numbers");

            //number[0] = int.Parse(Console.ReadLine());
            //number[1] = int.Parse(Console.ReadLine());
            //number[2] = int.Parse(Console.ReadLine());
            //number[3] = int.Parse(Console.ReadLine());

            for (i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Element[" + (i + 0) + ") : ");
                number[i] = int.Parse(Console.ReadLine());
            }
            int small = number[0];
            for (i=1; i<number.Length;i++)
            {
                if (small>number[i])
                    small = number[i];
            }
            Console.WriteLine("smallest No. in the array is {0}", small);      
        }
        
        }
    }

