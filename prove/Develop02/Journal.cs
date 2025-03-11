using System.IO;
class Journal
{
    private List<Entry> _entryList;

    public Journal()
    {
        _entryList = new List<Entry>();
    }

    public void AddEntry(Entry _entry)
    {
        _entryList.Add(_entry);
    }

    public void DisplayAllEntries()
    {

        foreach (Entry entry in _entryList)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void LoadFile(string _fileName)
    {
        string fileName = _fileName;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry newEntry = new Entry(date, prompt, response);
            _entryList.Add(newEntry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine(entry.CreateString());
            }
        }
    }


}