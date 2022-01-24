using System;

namespace Advancedarray
{


    class ArrayOperations
    {

        public int[] arr1 = new int[8] { 184, 15, 269, 658, 111, 2425, 0, 2 };
        public int[] arr2 = new int[5] { 20, 14, 5, 658, 2425 };
        public int[] arr = new int[8];
        public int i, j, n, temp1, k = 3;
        public bool check;


        public virtual bool Sort()
        {
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
                        for (i = 0; i < n; i++)
                        {
                            Console.WriteLine("Ascending Order is {0}", arr1[i]);
                        }

                    }

                }


            }
            return check;

        }




        public void BigSmallelement()
        {
            n = arr1.Length;

            Array.Sort(arr1);
            Console.WriteLine("Biggest No. in the array is {0}", arr1[n - 1]);
            Console.WriteLine("Smallest No. in the array is {0}", arr1[0]);



        }

        public void kthlargeelement()
        {
            int n = arr1.Length;

            for (i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp1 = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp1;
                    }
                }
            }
            for (i = 0; i < n; ++i)
            {

                if (i == k - 1)
                {
                    Console.WriteLine("{0}th Largest element is {1}", k, arr1[i]);

                }
            }
            for (i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (arr1[i] < arr1[j])
                    {
                        temp1 = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp1;
                    }
                }
            }
            for (i = 0; i < n; ++i)
            {

                if (i == k - 1)
                {
                    Console.WriteLine("{0}th smallest element is {1}", k, arr1[i]);

                }
            }
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
                                check = true;


                            }
                        }

                    }

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
