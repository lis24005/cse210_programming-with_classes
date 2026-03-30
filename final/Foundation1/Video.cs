using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

public class Video
{
    string _title;
    string _author;
    string _length;
    List<Comment> comments = new List<Comment>();
    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public string GetLength()
    {
        return _length;
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Length: {_length}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }
    }
}
