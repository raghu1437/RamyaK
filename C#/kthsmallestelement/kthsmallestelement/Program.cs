using System;

class Program
{

    public static void Main()
    {

        int[] numbers = new int[5];
        int i;

        for (i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter Elements [" + (i + 0) + "] :");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int temp = 0;
        int k;
        Console.WriteLine("Enter the position of element to be retrived - kth smallest number ");
        k = int.Parse(Console.ReadLine());
        for (i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; ++j)
            {
                if (numbers[i] < numbers[j])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;

                }
            }
        }
        for (i = 0; i < numbers.Length; ++i)
        {

            if (i == k - 1)
            {
                Console.Write("kth smallest element is {0}", numbers[i]);
                return;
            }
        }
    }

}






