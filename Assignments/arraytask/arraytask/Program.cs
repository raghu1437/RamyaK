using System;

namespace Advancedarray
{


    class ArrayOperations
    {

        public int[] arr1 = new int[5] { 184, 105, 2425, 18, 2 };
        public int[] arr2 = new int[5] { 20, 14, 5, 658, 2425 };
        public int[] arr = new int[8];
        public int i, j, n, temp1, k = 3;
        public bool check;

        public virtual bool Sort()
        {
            return check;
        }

        public virtual bool Sort(int[] arr1)
        {
            int n = arr1.Length;
            Console.WriteLine("Descending order");
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] < arr1[j])
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
                Console.WriteLine("{0}", arr1[i]);
            }

            Console.WriteLine("Ascending Order");
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp1 = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp1;
                        check = false;

                    }

                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", arr1[i]);

            }
           
            return check;

        }




        public void BigSmallelement()
        {
            n = arr1.Length;
            Sort(arr1);
            Console.WriteLine("***************");
            while (check == false)
            {
                Console.WriteLine("Smallest No. in the array is {0}", arr1[0]);
                Console.WriteLine("Biggest No. in the array is {0}", arr1[n - 1]);
                break;
            }
        }

        public void kthlargeelement()
        {
           
            do
            {
                Console.WriteLine("{0}th smallest element in the array is {1}", k, arr1[n - k]);
                Console.WriteLine("{0}th largest element is {1}", k, arr1[k - 1]);
                break;
            } while (check == false);
        }

    }


    class AdvancedArrayOperations : ArrayOperations
    {
        public void CommonElements()
        {
            int n1 = arr1.Length;
            int n2 = arr2.Length;
            
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (arr1[i] == arr2[j])
                        Console.WriteLine("Common Elements of the arrays are : {0} ", arr1[i]);
                }
            }
        }

        public override bool Sort()
        {

            string[] Names = new string[4] { "Geeth", "Ramya", "Ashik", "Rahul" };
            string Name = string.Empty;
            Console.WriteLine("Descending array of elements");


            for (i = 0; i < Names.Length; i++)
            {
                for (j = i + 1; j < Names.Length; j++)
                {
                    for (int c = 0; c < Names.Length; c++)
                    {
                        if (Names[i][c] < Names[j][c])
                        {
                            Name = Names[i];
                            Names[i] = Names[j];
                            Names[j] = Name;
                        }
                    }

                }

                Console.WriteLine(Names[i]);


            }
            Console.WriteLine("Ascending array of elements");
            
            for (i = 0; i < Names.Length; i++)
            {
                for (j = i + 1; j < Names.Length; j++)
                {
                    for (int c = 0; c < Names.Length; c++)
                    {
                        if (Names[i][c] > Names[j][c])
                        {
                            Name = Names[i];
                            Names[i] = Names[j];
                            Names[j] = Name;
                           
                        }
                    }

                }

                check = true;
                Console.WriteLine(Names[i]);


            }


            
            return check;

        }



        static void Main(string[] args)
        {
            AdvancedArrayOperations AAO = new AdvancedArrayOperations();
            AAO.Sort();
            Console.WriteLine("*******************************");
            AAO.BigSmallelement();
            Console.WriteLine("*******************************");
            AAO.kthlargeelement();
            Console.WriteLine("*******************************");
            AAO.CommonElements();
        }

    }
}
