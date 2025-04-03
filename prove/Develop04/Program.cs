using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "discription", 30);
        breathingActivity.RunActivity();
    }
}