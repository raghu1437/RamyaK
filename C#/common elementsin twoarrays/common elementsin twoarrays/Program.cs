using System;

namespace common_elementsin_twoarrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers1 = new int[5];
            int[] numbers2 = new int[5];


            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine("Enter elements of first array : Element1([" + (i + 0) + "] :");
                numbers1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < numbers2.Length; j++)
            {
                Console.WriteLine("Enter elements of second array : Element2([" + (j + 0) + "] :");
                numbers2[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers1.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers1[i] == numbers2[j])
                        Console.WriteLine("Common Elements of the arrays are : {0} ", numbers1[i]);
                }
            }
                
                
            

        }
    }
}
