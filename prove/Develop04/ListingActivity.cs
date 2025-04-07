class ListingActivity : Activity
{
    private string[] _prompt;
    public ListingActivity(string[] prompt, string name, string description, int durration) : base(name, description, durration)
    {
        _prompt = prompt;
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