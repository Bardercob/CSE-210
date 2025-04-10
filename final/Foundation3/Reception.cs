using System.ComponentModel.DataAnnotations;

class Reception : Event
{
    private string _email;

    public Reception(string eventTitle, string description, string date, string time, Address address, string email) : base(eventTitle, description, date, time, address)
    {
        _email = email;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event type: Resception, {base.StandardDetails()}\nEmail us for a seat: {_email}");
    }
}