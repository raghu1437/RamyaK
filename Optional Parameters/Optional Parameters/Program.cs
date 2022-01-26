using System;

namespace Optional_Parameters
{
    class Program
    {

       static public void Employee(string Name, float Salary, int age = 25, string CompanyName = "Infosys")
        {
            Console.WriteLine("Employee Name : {0} Employee Salary: {1}  Employee age:{2} CompanyName: {3}", Name, Salary, age, CompanyName);
            
        }
        static void Main(string[] args)
        {
            Employee("Ram", 10000);
            Employee("Seetha", 20000);
            Employee("Shyam", 30000);
            Employee("Lakshmi", 10000);

        }
    }
}
