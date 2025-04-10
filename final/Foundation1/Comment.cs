class Comment
{
    private string _commentorName;
    private string _commentText;
    public Comment(string commentorName, string commentText)
    {
        this._commentorName = commentorName;
        this._commentText = commentText;
    }

    public string CommentAsString()
    {
        return $"{_commentorName}: {_commentText}";
    }
}