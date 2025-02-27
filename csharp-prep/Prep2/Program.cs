using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        string letterGrade = "N";
        int gradeRemainder = gradePercentage % 10;
        string letterSign = "N";
        string aOrAn = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }

        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }

        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }

        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
        }

        if (gradeRemainder >= 7 && (letterGrade != "A" && letterGrade != "F"))
        {
            letterSign = "+";
        }
        else if (gradeRemainder <= 3 && letterGrade != "F")
        {
            letterSign = "-";
        }
        else
        {
            letterSign = "";
        }
        if (letterGrade == "A" || letterGrade == "F")
        {
            aOrAn = "n";
        }

        Console.WriteLine($"You got a{aOrAn} {letterGrade}{letterSign}");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else

        {
            Console.WriteLine("You did not pass, you will need to take it again");
        }
    }
}