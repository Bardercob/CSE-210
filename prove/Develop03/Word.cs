class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word, bool isHidden)
    {
        this._word = word;
        this._isHidden =isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void HideWord()
    {
        string temp = "";
        _isHidden = true;
        for (int i = 0; i < _word.Length; i++)
        {
            temp += '_';
        }
        _word = temp;
    }

    public string GetWord()
    {
        return _word;
    }

}