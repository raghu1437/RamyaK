using System;

public class Employee
{
	public string firstname;
	public string lastname;
	public string email;

	public void PrintFullName()
	{
		 
		Console.WriteLine("FullName {0} {1} email {2}", firstname, lastname, email);
	}
}
public class FullTimeEmployee : Employee
{
	public float yearlysalary;

}

public class ParttimeEmployee : Employee
{
	public float hourlyrate;

}

public class A : ParttimeEmployee
{

}
public class Program
{
	public static void Main()
	{
		FullTimeEmployee FTE = new FullTimeEmployee();
		FTE.firstname = "Ramya";
		FTE.lastname = "Narendra";
		FTE.email = "ramya.krishna59@gmail.com";
		FTE.yearlysalary = 300000;
		FTE.PrintFullName();
		ParttimeEmployee PTE = new ParttimeEmployee();
		PTE.firstname = "Samruddhi";
		PTE.lastname = "Ram";
		PTE.email = "samruddhiram@gmail.com";
		PTE.hourlyrate = 5000;
		PTE.PrintFullName();
		A A1 = new A();
		A1.firstname = "Naren";
		A1.email = "narenlokes@gmail.com";
		A1.PrintFullName();
	}


}