/*
Program name: Prep1
CSE 210
Author: Skyler Tietjen

Purpose: This program will ask the user for their first and last name, then print
it to the console
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}