using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 17);
        Scripture scripture = new Scripture(reference1, "For God sent not his Son into the world to condem the world: but that the world through him might be saved.");
        scripture.DisplayScripture();
    }
}