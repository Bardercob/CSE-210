using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, Type 0 when finished.");
        int userNumber = 1;
        int SmallestPositiveNumber = 9999999;
        List<int> numberList = new List<int>();
        while(userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numberList.Add(userNumber);
                if ((SmallestPositiveNumber > userNumber) && userNumber > 0)
                {
                    SmallestPositiveNumber = userNumber;
                }
            }

        }
        numberList.Sort();
        int numberSum = numberList.Sum();
        double numberAvarage = numberList.Average();
        int largestNumber = numberList.Max();
        Console.WriteLine($"The sum is: {numberSum}");
        Console.WriteLine($"The avarage is: {numberAvarage}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {SmallestPositiveNumber}");
        foreach(int number in numberList)
        {
            Console.WriteLine(number);
        }
    }
}