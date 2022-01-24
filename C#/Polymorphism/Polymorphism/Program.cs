using System;

public  class Employee
{
    public string firstname = "Ramya";
    public string lastname = "Narendra";

    public virtual void PrintFullName()
    {
        Console.WriteLine("FullName of the Employee is {0}", firstname + " " + lastname);

    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine("FullName of the Employee is {0}", firstname + " " + lastname + " - PartTime");

    }
}


public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine("FullName of the Employee is {0}", firstname + " " + lastname + " - FullTime");

    }
}

public class TemporaryEmployee : Employee
{
    public  void PrintFullName()
    {
        Console.WriteLine("FullName of the Employee is {0}", firstname + " " + lastname + " - Temporary");

    }
}


class Program
    {
        static void Main()
        {

        Employee [] E = new Employee[4];

        E[0] = new Employee();
        E[1] = new PartTimeEmployee();
        E[2] = new FullTimeEmployee();
        E[3] = new TemporaryEmployee();

        foreach (Employee emp in E)
            {
            emp.PrintFullName();
        }
        
    }
    }

