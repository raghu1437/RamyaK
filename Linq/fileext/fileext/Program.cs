using System;
using System.Collections.Generic;
using System.Linq;

namespace fileext
{
    class Program
    {
        List<string> file = new List<string>()
        {"file1.txt","file2.pdf","file3.txt","file4.txt","file5.jpg","file6.pdf" };

        static void Main(string[] args)
        {
            var Result = file.Select(f=>Path.GetExtension(f).TrimStart('.').ToLower())
                            .GroupBy(x=>x,(ext,extcnt) => new
                            {
                                Extesni
                            }
                            ))
                        
        }
    }


    public class Employee
    {
        public int id, Salary;
        public string Name, Department;
       
    }
}
