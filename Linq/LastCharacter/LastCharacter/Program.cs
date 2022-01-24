using System;
using System.Collections.Generic;
using System.Linq;

namespace LastCharacter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List <Employee> employees = new List<Employee>()
            {
                new Employee() {ID = 101, Name = "Sravan", Age = 12},
                new Employee() {ID = 102, Name = "deepu",  Age = 15},
                new Employee() {ID = 103, Name = "manoja", Age = 13},
                new Employee() {ID = 104, Name = "Sathwik", Age = 12},
                new Employee() {ID = 105, Name = "Saran",  Age = 15}
            };

           IEnumerable<Employee> QS = (from emp in employees
                                        where emp.Name[emp.Name.Length - 1] == 'n'
                                        select emp);

            foreach(Employee e in QS)
            {
                Console.WriteLine(e.ToString());
            }

            var MS = employees.Select(emp=>new { n = emp.Name.Length - 1 == 'n' }
            foreach(Employee e in MS)
            {
                Console.WriteLine(e.ToString())
            }
        }

    }
    public class Employee
    {
        public int ID;
        public string Name;
        public int Age;

        public override string ToString()
        {
            return ID + " " + Name + " " + Age;
        }

    }

}
