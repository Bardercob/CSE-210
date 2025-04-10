using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        Video video1 = new Video("movie", "Jesebell", 7200);
        Comment video1Comment1 = new Comment("Halle", "This is good...");
        video1.AddComment(video1Comment1);
        Comment video1Comment2 = new Comment("lills", "The best Movie of 2021!");
        video1.AddComment(video1Comment2);
        Comment video1Comment3 = new Comment("Mac", "Uhh, I've seen better :(");
        video1.AddComment(video1Comment3);
        videoList.Add(video1);
        Video video2 = new Video("Addvertisment", "PCmilk inc", 30);
        Comment video2Comment1 = new Comment("James", "ABSOLUTLY HILARIOUS!");
        video2.AddComment(video2Comment1);
        Comment video2Comment2 = new Comment("Youtuber^_^", "My favorite part is when that guy thinks his compputer is on fire. XD");
        video2.AddComment(video2Comment2);
        Comment video2Comment3 = new Comment("urmom1234#yw9jdd023fj9w9239f3fu9we0903w", "XP");
        video2.AddComment(video2Comment3);
        videoList.Add(video2);
        Video video3 = new Video("Videogame Spedrun", "Speedygameerman1", 458);
        Comment video3Comment1 = new Comment("Lilly", "Nice Run!");
        video3.AddComment(video3Comment1);
        Comment video3Comment2 = new Comment("Jo", "WOW HOW U SO FAST!?!?!???!");
        video3.AddComment(video3Comment2);
        Comment video3Comment3 = new Comment("Little timmy", "Mi mMMy SaI I noT spossd o Woth Yutob,");
        video3.AddComment(video3Comment3);
        videoList.Add(video3);
        foreach(Video video in videoList)
        {
            Console.WriteLine(video.VideoAsString());
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}