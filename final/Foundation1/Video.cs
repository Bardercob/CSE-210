class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> commentList;

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
        commentList = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        commentList.Add(comment);
    }

    public string VideoAsString()
    {
        return $"Title: {_title}, Author: {_author}, length: {_length}, Comments:{commentList.Count()}";
    }

    public void DisplayComments()
    {
        foreach(Comment comment in commentList)
        {
            Console.WriteLine(comment.CommentAsString());
        }
    }

}