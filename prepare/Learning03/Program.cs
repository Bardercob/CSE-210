using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(2, 3);
        Console.WriteLine(fraction.GetFractionString());
        fraction.GetDecimalValue();
        Console.WriteLine(fraction.GetDecimalValue());
    }
}