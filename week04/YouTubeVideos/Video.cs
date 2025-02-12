using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"🎬 Video: {_title}");
        Console.WriteLine($"👤 Author: {_author}");
        Console.WriteLine($"⏳ Duration: {_lengthInSeconds} seconds");
        Console.WriteLine($"💬 Comments: {GetNumberOfComments()}");
        Console.WriteLine("------------------------------------------------");

        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}
