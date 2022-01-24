using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int, string> Mydict = new Dictionary<int, string>();
            Mydict.Add(15, "GM");
            Mydict.Add(14, "GA");
        foreach (KeyValuePair<int, string> res in Mydict)
        {
            Console.WriteLine("{0}{1}, res.Key,res.Value");
        }
        Mydict.Count();
        Mydict.Clear();

        Mydict.remove(15);

        }
    }
