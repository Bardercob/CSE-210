class Circle
{
    private double _radius;

    public Circle(double r)
    {
        _radius = r;
    }

    public double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }

    public void displayCircleArea()
    {
        Console.WriteLine($"The area of the circle is {GetArea()}");
    }

    public void SetRadius(double r)
    {
        _radius = r;
    }
}