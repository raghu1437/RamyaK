using System;

class Customer
{
    public static string firstname;
    public static string lastname;

    public Customer() : this("No Firstname provided", "No LastName Provided")
    { 
    }
    
    static Customer()
    {
        firstname = "Ramya";
        lastname = "K";

    }
    public void PrintName()
    {
        Console.WriteLine("FullName = {0}", this.firstname + " " + this.lastname);
    }
    ~Customer()
    {
        
    }

}

class program
{
    public static void Main()
    {
        Customer C = new Customer();
        C.PrintName();

        Customer C1 = new Customer("Ramya", "Narendra");
        C1.PrintName();
    }
}