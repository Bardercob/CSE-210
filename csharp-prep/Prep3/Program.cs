using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 100) + 1;
        int numberGuess = -19084237;
        Console.WriteLine("Welcome to \"Guess The Number!\"");
        
        while (magicNumber != numberGuess)
        {
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());
            if (magicNumber > numberGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < numberGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}