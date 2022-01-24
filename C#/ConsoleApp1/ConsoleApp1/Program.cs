using System;

class Program
{
    static void Main()
    {

        Program.Evennumbers(5);

        Program p = new Program();
        int sum = p.add(40,50);
        Console.WriteLine(sum + " ");
    }


    public int add (int x, int y)
    {
        return x + y;
    }
    public static void Evennumbers(int target)
    {
        int start = 0;
        while (start <= target)
        {
            Console.Write(start + " ");
            start += 2;
        }
    }
}
