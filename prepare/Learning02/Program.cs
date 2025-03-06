using System;

class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job("Taco Time", "CEO", 2020, 2022);
        myFirstJob.DisplayJob();
        Job mySecondJob = new Job("Mcdonalds", "dumpster", 2019, 2020);
        myFirstJob.DisplayJob();
        Resume myResume = new Resume("Jesabell");
        myResume.AddJob(myFirstJob);
        myResume.AddJob(mySecondJob);
        myResume.DisplayResume();
    }
}