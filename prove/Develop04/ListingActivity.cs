class ListingActivity : Activity
{
    private string _prompt;
    public ListingActivity(string prompt, string name, string description, int durration) : base(name, description, durration)
    {
        _prompt = prompt;
    }

    public void RunActivity()
    {
        DisplayActivityStart();
        SetDurration();
        MakeSpinner("Get Ready...", 4);
        Console.WriteLine("List as many prompts as you can to the following prompt:");
        Console.WriteLine($"---{_prompt}---");
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
        DisplayActivityEnd($"You have completed another {GetDurration()} seconds of the Listing Activity");
    }
}