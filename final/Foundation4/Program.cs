using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        Running running = new Running("09 Dec 2023", 90, 6.0);
        activityList.Add(running);
        Swimming swimming = new Swimming("21 Mar 2024", 30, 5);
        activityList.Add(swimming);
        Cycling cycling = new Cycling("05 June 2025", 45, 9);
        activityList.Add(cycling);

        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummery());
        }
    }
}