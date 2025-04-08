class ReflectionActivity : Activity
{
    private string[] _prompt = [
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."];
    private string[] _reflectionQuestion = [
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"];

    public ReflectionActivity(string name, string description, int durration) : base(name, description, durration)
    {

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