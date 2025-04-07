using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int menuValue = 0;
        while (menuValue != 4)
        {
            menuValue = menu.DisplayMenu();
            switch (menuValue)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("breathing",
                    "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.", 0);
                    breathingActivity.RunActivity();
                    break;
                case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity([
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."], [
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"], "reflection",
                "This activity will help you reflect on times in your life when you have shown strength and\nresilience. This will help you recognize the power you have and how you can use it in other\naspects of your life.", 0);
                reflectionActivity.RunActivity();
                break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity(["Who are people that you appreciate?", "What are personal strengths of yours?",
                    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"],
                    "listing", "This activity will help you reflect on the good things in your life by having you list\nas many things as you can in a certain area.", 0);
                    listingActivity.RunActivity();
                    break;

                default:
                    break;

            }
        
        }
        
    }
}