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
                    ReflectionActivity reflectionActivity = new ReflectionActivity("reflection",
                    "This activity will help you reflect on times in your life when you have shown strength and\nresilience. This will help you recognize the power you have and how you can use it in other\naspects of your life.", 0);
                    reflectionActivity.RunActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("listing",
                    "This activity will help you reflect on the good things in your life by having you list\nas many things as you can in a certain area.", 0);
                    listingActivity.RunActivity();
                    break;

                default:
                    break;

            }
        
        }
        
    }
}