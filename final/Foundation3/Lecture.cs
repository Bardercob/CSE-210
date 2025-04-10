class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event type: Lecture, {base.StandardDetails()}\nSpeaker: {_speaker}, Capacity: {_capacity}");
    }
}