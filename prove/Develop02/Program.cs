using System;
using System.IO.Enumeration;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;
        Journal currentJournal = new Journal();
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
            string[] promptArray = ["Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
            "If I had one thing I could do over today, what would it be?", 
            "What was the strongest emotion I felt today?"];
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            Prompt newPrompt = new Prompt(promptArray, false);
            string prompt1 = newPrompt.GetPrompt(promptArray, true);
            string response = Console.ReadLine();
            Entry newEntry = new Entry(dateText, prompt1, response);
            currentJournal.AddEntry(newEntry);
            }

            if (choice == 2)
            {
                currentJournal.DisplayAllEntries();
            }

            if (choice == 3)
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                currentJournal.LoadFile(fileName);
            }

            if (choice == 4)
            {
                Console.WriteLine("What is the file name");
                string fileName = Console.ReadLine();
                currentJournal.SaveToFile(fileName);
            }
        }
    }
}