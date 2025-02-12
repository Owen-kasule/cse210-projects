using System;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"💬 {_commenterName}: {_commentText}");
    }
}