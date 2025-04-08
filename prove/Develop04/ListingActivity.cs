class ListingActivity : Activity
{
    private string[] _prompt = ["Who are people that you appreciate?", "What are personal strengths of yours?",
    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    public ListingActivity(string name, string description, int durration) : base(name, description, durration)
    {

    }

    public void RunActivity()
    {
        DisplayActivityStart();
        SetDurration();
        MakeSpinner("Get Ready...", 4);
        Console.WriteLine();
        Console.WriteLine("List as many response as you can to the following prompt:");
        Console.WriteLine($"---{ChooseRandom(_prompt)}---");
        RunCountDown("You may begin in: ", 5);
        DateTime rightNow = DateTime.Now;
        DateTime endTime = rightNow.AddSeconds(GetDurration());
        int listedItems = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            listedItems += 1;
        }
        Console.WriteLine($"You listed {listedItems} items!");
        Console.WriteLine();
        DisplayActivityEnd(GetDurration());
    }
}