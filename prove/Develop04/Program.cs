using System;

class Program
{
    static void Main(string[] args)
    {
        // BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.", 0);
        // breathingActivity.RunActivity();
        ListingActivity listingActivity = new ListingActivity(Activity.ChooseRandomPrompt(), "Listing", "This activity will help you reflect on the good things in your life by having you list\bas many things as you can in a certain area.", 0);
        listingActivity.RunActivity();
    }
}