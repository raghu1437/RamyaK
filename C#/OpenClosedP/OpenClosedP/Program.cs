using System;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }

    public string EmployeeType { get; set; }
    public Employee()
    {

    }
    public Employee(int id, string name, string employeeType)
    {
        this.ID = id;
        this.Name = name;
        this.EmployeeType = employeeType;

    }

    public decimal CalculateBonus(decimal salary)
    {
        if (this.EmployeeType == "Permanent")
            return salary * .1M;
        else
            return salary * .05M;

    }

    public override string ToString()
    {
        return string.Format("ID: {0} Name : {1}", this.ID, this.Name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee(1, "Ram", "Permanent");
        Employee emp2 = new Employee(2, "Shyam", "Temporary");

        Console.WriteLine(string.Format("Employee {0} Bonus :{1}",
        emp1.ToString(), emp2.CalculateBonus(100000).ToString()));
        Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
        emp2.ToString(), emp2.CalculateBonus(100000).ToString()));
        Console.ReadLine();

    }
}

