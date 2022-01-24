using System;
class CalculateMean
{

    static void Main()
    {
        float sum = 0;
        int[] numbers = new int[8];


        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element [" + (i + 0) + "]: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //numbers[0] = int.Parse(Console.ReadLine());
        //numbers[1] = int.Parse(Console.ReadLine());
        //numbers[2] = int.Parse(Console.ReadLine());
        //numbers[3] = int.Parse(Console.ReadLine());
        //numbers[4] = int.Parse(Console.ReadLine());
        //numbers[5] = int.Parse(Console.ReadLine());
        //numbers[6] = int.Parse(Console.ReadLine());
        //numbers[7] = int.Parse(Console.ReadLine());

        foreach (float x in numbers)
        {
            sum+=x;

        }
        float mean = (sum / numbers.Length);
        Console.WriteLine(" Mean is {0}", mean);


    }
}
