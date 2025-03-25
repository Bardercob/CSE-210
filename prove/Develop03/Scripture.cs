class Scripture
{
    private Reference _scriptureReference;
    private List<Word> _wordList;
    
    public Scripture(Reference reference, string verseText)
    {
        _scriptureReference = reference;
        _wordList = new List<Word>();
        string[] tempWords = verseText.Split(' ');
        foreach (string word in tempWords)
        {
            Word word1 = new Word(word, false);
            _wordList.Add(word1);
        }
    }

    public void DisplayScripture()
    {
        Console.Write(_scriptureReference.GetReference());
        foreach(Word word in _wordList)
        {
            Console.Write($" {word.GetHiddenWord()}");
        }
    }
}