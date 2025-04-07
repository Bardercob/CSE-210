class ReflectionActivity : Activity
{
    private string[] _prompt;
    private string[] _reflectionQuestion;

    public ReflectionActivity(string[] prompt, string[] reflectionQuestion, string name, string description, int durration) : base(name, description, durration)
    {
        _prompt = prompt;
        _reflectionQuestion = reflectionQuestion;
    }

    public void RunActivity()
    {
        DisplayActivityStart();
        SetDurration();
        MakeSpinner("Get Ready...", 4);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{ChooseRandom(_prompt)}---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        RunCountDown("You may begin in: ", 5);
        Console.Clear();
        DateTime rightNow = DateTime.Now;
        DateTime endTime = rightNow.AddSeconds(GetDurration());
        while(DateTime.Now < endTime)
        {
            MakeSpinner(ChooseRandom(_reflectionQuestion), 13);
        }
        Console.WriteLine();
        DisplayActivityEnd(GetDurration());

    }
}