class ListingActivity : Activity
{
    private List<string> _prompt;
    public ListingActivity(List<string> prompt, string name, string description, int durration) : base(name, description, durration)
    {
        _prompt = prompt;
    }

    public void DisplayPrompt()
    {
        int index = -1;
        Random random = new Random();
        index = random.Next(_prompt.Count);
        string prompt = _prompt[index];
    }

    public void RunActivity()
    {
        DisplayActivityStart();
        RunCountDown("Breath in: ", 6);
        RunCountDown("Breath out: ", 4);
    }
}