class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endverse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endverse;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_startVerse}";
    }
}