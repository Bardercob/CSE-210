class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, string weather) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event type: OutDoor Gathering, {base.StandardDetails()}\nWeather forecast: {_weather}");
    }
}