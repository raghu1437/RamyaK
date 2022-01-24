using System;

public class Program
{
    public static void Main()
    {



        int[] arr1 = new int[8] { 184, 15, 269, 658, 111, 2425, 0, 2 };
        int[] arr2 = new int[5] { 20, 14, 5, 658, 2425 };
        int i, j, p, q, temp1, temp2;
        bool check;
        int n = arr1.Length;
        Console.WriteLine("Ascending Order");
        int n = arr1.Length;

        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (arr1[i] > arr1[j])
                {
                    temp1 = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = temp1;
                    check = true;
                }
            }

        }
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Ascending Order is {0}", arr1[i]);
        }

        for (p = 0; p < n; p++)
        {
            for (q = p + 1; q < n; q++)
            {
                if (arr1[p] > arr1[q])
                {
                    temp2 = arr1[p];
                    arr1[p] = arr1[q];
                    arr1[q] = temp2;

                    check = false;
                }
            }
        }
        for (p = 0; p < n; p++)
        {
            Console.WriteLine("Descending Order is {0}", arr1[p]);
        }
        return check;
    }

}