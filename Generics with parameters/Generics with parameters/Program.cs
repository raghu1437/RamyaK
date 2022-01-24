using System;

namespace Generics_with_parameters
{


    public class Display
    {
        public void Dis<TypeofValue>(string msg, TypeofValue Value)
        {
            Console.WriteLine("{0},{1}", msg, Value);
        }

        public void Add<TypeofValue>(int A, TypeofValue B)
            {
            Console.WriteLine("{ 0}", A + B)
;        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Display D = new Display();
            D.Dis<int>("Hi", 1);
            D.Dis<string>("Hello", "ok");
            D.Dis<double>("welcome", 3.78);


            Add data = new Add();
            data.Add<int>(10, 10);
            data.Add<string>("Pine", "Apple");

                }
    }
}
