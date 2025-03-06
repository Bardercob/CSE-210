using System;
using System.Formats.Asn1;

class Program
{   
    public static int Addnumbers(int n, int m)
    {
        return n + m;
    }
    static void Main(string[] args)
    {

        Circle myCircle = new Circle(10);
        myCircle.displayCircleArea();
        // Circle myCircle2 = new Circle(20);
        // myCircle2.displayCircleArea();
        Cylinder myCylinder = new Cylinder(10, myCircle);
        double volume = myCylinder.GetVolume();
        Console.WriteLine($"The cylinder volume is: {volume}");

        // for(int i = 0; i < 31; i++)
        // {
        //     myCircle.SetRadius(i);
        //     double circleArea = myCircle.GetArea();
        //     Console.WriteLine($"{i}: Circle area is: {circleArea}");
        // }
    }
    
}