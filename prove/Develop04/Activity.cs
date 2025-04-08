
class Activity
{
    private string _name;
    private string _description;
    private int _durration;
    private DateTime _endTime;

    public Activity(string name, string description, int durr)
    {
        this._name = name;
        this._description = description;
        this._durration = durr;
        this._endTime = DateTime.Now;
    }

    public void SetDurration()
        {
            Console.Write("How long do you want to do the activity for(sec)? ");
            this._durration = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public int GetDurration()
        {
            return _durration;
        }
    public void DisplayActivityStart()
    {
        Console.Clear();
        Console.WriteLine($"welcome to the {_name} activity!\n");
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayActivityEnd(int durration)
    {
        
        MakeSpinner("Well Done!", 3);
        Console.WriteLine();
        MakeSpinner($"You have completed another {durration} seconds of the {_name} activity.", 5);
    }

    public void RunCountDown(string message, int durration)
    {
        DateTime rightNow = DateTime.Now;
        _endTime = rightNow.AddSeconds(durration);
        Console.Write($"{message}{durration}");
        while (durration > 0)
        {
            Console.Write("\b");
            Console.Write(durration --);
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b0");
    }

    public void MakeSpinner(string message, int seconds)
    {
        char[] spinner = ['|', '/', '-', '\\'];
        Console.Write(message);
        for(int i = 0; i < seconds * 2; i++)
        {
            foreach(char character in spinner)
            {
                Console.Write(character);
                Thread.Sleep(125);
                Console.Write("\b");
            }
        }
        Console.WriteLine(" ");
    }

    public static string ChooseRandom(string[] randomList)
    {
        int index = -1;
        Random random = new Random();
        index = random.Next(randomList.Count());
        string prompt = randomList[index];
        return prompt;
    }
}