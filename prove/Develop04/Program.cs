using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.", 0);
        breathingActivity.RunActivity();
    }
}