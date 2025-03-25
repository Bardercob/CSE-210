class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word, bool isHidden)
    {
        this._word = word;
        this._isHidden =isHidden;
    }

    public string GetHiddenWord()
    {
        return _word;
    }
}