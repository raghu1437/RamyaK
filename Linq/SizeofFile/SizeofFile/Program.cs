using System;
using System.Linq;
 
using System.IO;

namespace SizeofFile
{
    class Program
    {

        static void Main(string[] args)
        {
        
            var filesize= Directory.GetFiles("documents\\sample\\");
            var average = filesize.Select(file => new FileInfo(file).Length).Average();
            average = Math.Round(average / 10, 1);
            Console.WriteLine("The Average size of the file is {0} MB", average);
        }
    }
}
