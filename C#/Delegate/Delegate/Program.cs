using System;

namespace Delegate
{

    public delegate void Hellodelegate(string Str);
    class Program
    {
        static void Main(string[] args)
        {
            Hellodelegate del = new Hellodelegate(Hello);
            del("Hello from Delegate");
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
