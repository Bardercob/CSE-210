class Activity
{
    private string _name;
    private string _description;
    private int _durration;

    public Activity(string name, string description, int durration)
    {
        this._name = name;
        this._description = description;
        this._durration = durration;
    }

    public void DisplayActivityStart()
    {
        Console.WriteLine($"welcome to the {_name} activity!");
    }

    public void DisplayActivityEnd()
    {
        
    }
}