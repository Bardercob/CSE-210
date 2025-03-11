using System.ComponentModel;

class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    public Entry(string date, string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public string CreateString()
    {
        string entry = $"{_date}|{_prompt}|{_response}";
        return entry;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}");
    }

}