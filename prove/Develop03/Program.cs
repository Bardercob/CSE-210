using System;

class Program
{
    static void Main(string[] args)
    {
        bool allHidden = false;

        Console.WriteLine("Welcome to the scripture memorization program!");
        Console.WriteLine("Press enter to hide three words.");

        Reference reference1 = new Reference("John", 3, 17);
        Scripture scripture1 = new Scripture(reference1, "For God sent not his Son into the world to condem the world: but that the world through him might be saved.");
        while (! allHidden)
        {
            scripture1.DisplayScripture();
            string userInput = Console.ReadLine();
            for(int i = 0; i < 3; i++)
            {
            scripture1.HideRandomWords();
            allHidden = scripture1.CheckAllHidden();
            if (allHidden)
            {
                break;
            }
            }
        }
    }
}