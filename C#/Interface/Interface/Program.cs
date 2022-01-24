using System;

interface ICustomer
{
       void print();
    
 }

interface ICustomer2 
{
     void print2();
}
    class Customer : ICustomer, ICustomer2
    {
    public void print()
    {
        Console.WriteLine("Print Name");
    }
    public void print2()
    {
        Console.WriteLine("hi");
    }
}
//Class Customer : ICustomer2
//{
//   interface ICustomer2: ICustomer1
//    if a class inherits a interface and an interface inherits another inteface than the class should implement all the methods in both interface }
    class Program
    {
        static void Main()
        {
        Customer C = new Customer();
        C.print();
        C.print2();
        }
    }

