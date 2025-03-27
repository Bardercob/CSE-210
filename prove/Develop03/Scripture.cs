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
            Console.Write($" {word.GetWord()}");
        }
    }

    public void HideRandomWords()
    {
        Random randomHidden = new Random();
        int index = -1;
        do
        {
        index = randomHidden.Next(_wordList.Count);

        if (! _wordList[index].GetIsHidden())
        {
            _wordList[index].HideWord();
            _wordList[index].SetIsHidden(true);
            break;
        }
        } while (_wordList[index].GetIsHidden());
    }

    public bool CheckAllHidden()
    {
        int hiddenWords = 0;
        foreach(Word word in _wordList)
        {
            
            if (word.GetIsHidden())
            {
                hiddenWords += 1;
            }
        }
        if (hiddenWords == _wordList.Count)
        {
            bool allHidden = true;
            return allHidden;
        }
        else
        {
            bool allHidden = false;
            return allHidden;
        }
        
    }
}