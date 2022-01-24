using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace fileext
{
    class Program
    {
       

        static void Main(string[] args)
        {
            List<string> file = new List<string>()
                        {"file1.txt","file2.pdf","file3.txt","file4.txt","file5.jpg","file6.pdf" };
            
            
            var Result = file.Select(f => Path.GetExtension(f)
                            .TrimStart('.').ToLower())
                            .GroupBy(x => x, (ext, extcnt) => new
                            {
                                Extension = ext,
                                Count = extcnt.Count()
                            }); 
          foreach(var res in Result)
            {
                Console.WriteLine(res.Count, res.Extension);
            }
                        
        }
    }


    public class Employee
    {
        public int id, Salary;
        public string Name, Department;
       
    }
}
