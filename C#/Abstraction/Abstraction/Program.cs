using System;

    public class Customer 
    {
    public string CustomerCode;
    public string CustomerName;
    public void Add()
    {
    Validate();
    Createdbobjects();

    }

    private bool Validate()
    {
        return true;
    }

    private bool Createdbobjects()
    {
        return true;

    }
}
    
class Program
{ 

    static void Main()
    {
        Customer obj = new Customer();
        obj.CustomerCode = "0011";
        obj.CustomerName = "Ramya";
        obj.Add();
    }

}


