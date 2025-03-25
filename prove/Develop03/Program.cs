using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Jacob", 3, 3);
        Console.WriteLine(reference1.GetReference());
    }
}