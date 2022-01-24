using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
           List <string> FileName = new List<string>()
            {
                "A.jpg", "B.txt", "C.docx", "D.txt", "E.txt", "F.jpg", "G.txt"
            };
            string result = Path.GetExtension(FileName);
                
        }

    }
}
