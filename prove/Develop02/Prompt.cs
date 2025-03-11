using System.Reflection.Metadata.Ecma335;

class Prompt
{
    private string[] _prompt;
    private bool _display;

    public Prompt(string[] prompt, bool display)
    {
        _prompt = prompt;

        _display = display;
    }

    public string GetPrompt(string[] _prompt, bool _display)
    {
        Random randomGenerator = new Random();
        int pindex = randomGenerator.Next(_prompt.Length);
        string prompt = _prompt[pindex];
        if (_display)
        {
            Console.WriteLine(_prompt[pindex]);
        }
        return prompt;
    }
}