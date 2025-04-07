
class Activity
{
    private string _name;
    private string _description;
    private int _durration;
    private DateTime _endTime;

    public Activity(string name, string description, int durration)
    {
        this._name = name;
        this._description = description;
        this._durration = durration;
        _endTime = DateTime.Now;
    }

    public void DisplayActivityStart()
    {
        Console.WriteLine($"welcome to the {_name} activity!");
    }

    public void DisplayActivityEnd()
    {
        
    }

    public void RunCountDown(string message, int durration)
    {
        DateTime rightNow = DateTime.Now;
        _endTime = rightNow.AddSeconds(durration);
        Console.Write($"{message}{durration}");
        while (DateTime.Now < _endTime)
        {
            Console.Write("\b");
            Console.Write(durration --);
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b0");
    }

    public void MakeSpinner()
    {
        char[] spinner = ['|', '/', '-', '\\'];
        for(int i = 0; i < 10; i++)
        {
        foreach(char character in spinner)
        {
            Console.Write(character);
            Thread.Sleep(125);
            Console.Write("\b");
        }
        }
        Console.Write(" ");
    }
}