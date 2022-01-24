using System;
public abstract class Fruit
{
    public abstract void DisplayColor();
    
}

public  class Apple : Fruit
{
    public override void DisplayColor()
    {
        Console.WriteLine("Color of Apple is Red");

    }
}
public  class Orange : Fruit
{
    public override void DisplayColor()
    {
        Console.WriteLine("Color of Orange is Orange");
    }
}
    class Program
    {
        static void Main(string[] args)
        { 
       Fruit F = new Apple();
        F.DisplayColor();

        F = new Orange();
        F.DisplayColor();
        }
    }
