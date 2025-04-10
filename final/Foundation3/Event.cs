class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return $"{_eventTitle}: {_description}\n Date: {_date}, Time: {_time}\nAddress: {_address.AddressStringFormat()}";
    }

    public void DisplayShortDescription()
    {
        string eventType = "";
        if (base.ToString() == "OutdoorGathering")
        {
            eventType = "Outdoor Gathering";
        }
        else
        {
            eventType = base.ToString();
        }
        Console.WriteLine($"Event type: {eventType}, {_eventTitle} Date:{_date}");
    }
}