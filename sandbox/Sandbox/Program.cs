using System;
using System.Formats.Asn1;

class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double GetArea()
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    public void displayCircleArea()
    {
        Console.WriteLine($"The area of the circle is {GetArea()}");
    }

    public void SetRadius(double r)
    {
        radius = r;
    }
}

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
        Circle myCircle2 = new Circle(20);
        myCircle2.displayCircleArea();

        for(int i = 0; i < 30; i++)
        {
            myCircle.SetRadius(i);
            double circleArea = myCircle.GetArea();
            Console.WriteLine($"{i}: Circle area is: {circleArea}");
        }
    }
    
}