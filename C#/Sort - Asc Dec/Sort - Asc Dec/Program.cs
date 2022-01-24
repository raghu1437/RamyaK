using System;

namespace Sort___Asc_Dec
{

    public class AscSorting
    {
        int[] numbers = new int[5];
        int i;
        int j;
        public void RcvInput()
        {
           
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Elements for ascending order [" + (i + 0) + "]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
       
        public void Acorder()
        {
           
            for (i = 0; i < numbers.Length; ++i)
            {
                for (j = i + 1; j < numbers.Length; ++j)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;

                    }

                }

            }
            for (i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine("Ascending order of Nos.{0}", numbers[i]);

            }
        }
    }

    public class DscSorting 
    {
        int[] numbers = new int[5];
        int i;
        int j;
        public void RcvInput1()
        {

            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Elements for Descending order [" + (i + 0) + "]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        public void dcorder()
        { 
        
       
            for (i = 0; i < numbers.Length; ++i)
            {
                for (j = i + 1; j < numbers.Length; ++j)
                {
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;

                    }

                }

            }
            for (i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine("Descending  order of Nos.{0}", numbers[i]);

            }
        }

    }

    public class Whichordersort
    {
        int[] numbers = new int[5];
        int i;
        int j;
        bool Asc = true;
        bool Dsc = true;
        public void AorD()
        {
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Elements for ascending order [" + (i + 0) + "]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            i = 0;

            while ((Asc == true || Dsc == true) && i < numbers.Length - 1)
            {
                if (numbers[i] < numbers[i + 1])
                    Dsc = false;
                else if (numbers[i] > numbers[i + 1])
                    Asc = false;
                i++;

            }
            if (Asc == true)
                Console.WriteLine("the array is sorted in Ascending Order");
            else if (Dsc == true)
                Console.WriteLine("the array is sorted in Descending Order");
            else
                Console.WriteLine("the array is not sorted");
        }
    }
        public class program

        {
            bool A=true;
            bool D=true;
            int[] numbers = new int[5];
        
            int i = 0;

            public static void Main()
            {
                //AscSorting AS = new AscSorting();
                //AS.RcvInput();
                //AS.Acorder();
                
                //DscSorting DS = new DscSorting();
                //DS.RcvInput1();
                //DS.dcorder();

                Whichordersort WOS= new Whichordersort();
                WOS.AorD();

                   

            }
        }
    }


