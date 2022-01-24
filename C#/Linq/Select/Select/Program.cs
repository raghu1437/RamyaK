using System;
using System.Linq;
using System.Collections.Generic;

namespace Select
{
    class Program
    {
        static void Main()
        {

            List <Employee> employees = new List<Employee>()
            {
                new Employee(){ID=1,Name="Ramya",Dept="ISE" },
                new Employee(){ID=2,Name="Asha",Dept="ISE" },
                new Employee(){ID=3,Name="Prithvi",Dept="ISE" },
                new Employee(){ID=4,Name="Praveen",Dept="ISE" },
                new Employee(){ID=5,Name="Naren",Dept="ISE" }
            };
            var query = (from emp in employees
                        select emp).ToList();

            foreach(var item in query)
            {
                Console.WriteLine("id :{0} Name:{1} Dept:{2}", item.ID,item.Name,item.Dept);
            }

        }
    }

    public class Employee
    {
       public int ID { get; set; }
        public string Name { get; set; }
       public string Dept { get; set; }
    }
}
