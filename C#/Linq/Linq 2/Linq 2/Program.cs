using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                  new Employee(){ID=1, Name = "Ramya"},
                  new Employee(){ID=2, Name = "Naren"}
        };

        IEnumerable<Employee> query = from emp in employees
                                      where emp.ID == 1
                                      select emp;



            foreach (var item in query)
            {
                Console.WriteLine("Id= " + item.ID+" and Name = " +item.Name);
            }


            IEnumerable<Employee> method = employees.AsEnumerable().Where(x=>x.ID==2);
            foreach (var item in query)
            {
                Console.WriteLine("Id= " + item.ID + " and Name = " + item.Name);
            }
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
