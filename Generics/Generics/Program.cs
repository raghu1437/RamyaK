using System;
using System.Collections.Generic;

public class Student<T>
{
    private T ID;
    private T Name;
    public T IdValue;
    public T NameValue;

    private T rollNo
    {
        get { return this.ID; }
        set { this.ID=IdValue ; }

    }

    private T stName
    {
        get { return this.Name; }
        set { this.Name = NameValue; }
    }

}


class Program
{
    static void Main(string[] args)
    {
        Student<string> studentName  = new Student<string>();
        studentName.NameValue = "Ramya";
        Student<int> studentID = new Student <int> ();
        studentID.IdValue = 1305;
        Student

        {

        }
    }
}