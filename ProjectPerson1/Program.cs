using System;

class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Bubba", 97);

        Console.WriteLine($"{myPerson.DisplayPersonInfo()}");

        MailMan myMailMan = new MailMan("Taser", "Joe", "hoseph", 32);
        Console.WriteLine($"{myMailMan.DisplayMailManInfo()}");
        Console.WriteLine($"{myMailMan.DisplayPersonInfo()}");
    }
}