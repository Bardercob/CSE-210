using System;
using System.Runtime.InteropServices;

class Program
{   
    public static int Addnumbers(int n, int m)
    {
        return n + m;
    }
    static void Main(string[] args)
    {
        // for(float i = 0; i < 20; i += 0.3F)
        // {
        //     Console.WriteLine($"{i + 1}: bob");
        // }

        List<int> numbers = new List<int>{1, 2, 3, 4, 5};
        numbers.Add(10);

        foreach(int x in numbers)
        {
            Console.WriteLine($"{x}");
        }

        // bool correctInput = false;
        // while(!correctInput)
        // {
        //     Console.Write("please input your age ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 120)
        //     {
        //         Console.WriteLine($"Your age is: {age}");
        //         correctInput = true;
        //     }
        // }
        // bool correctInput = false;
        // do
        // {
        //     Console.Write("please input your age ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 120)
        //     {
        //         Console.WriteLine($"Your age is: {age}");
        //         correctInput = true;
        //     }
        // } while(!correctInput);

        Random newRandomNumber = new Random();
        for(int x = 0; x < 10; x++)
        {
            int number = newRandomNumber.Next(1, 1000);
            Console.WriteLine($"{number}");
        }

        int total = Addnumbers(4, 5);
        Console.WriteLine($"{total}");
    }
}