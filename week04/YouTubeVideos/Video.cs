using System;

public class Video
{
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
        {
            _title = title;
            _author = author;
            _seconds = duration;
        }

    public void Display(){
        Console.WriteLine($"Title: {_title} \nAuthor: {_author}\nDuration: {_seconds}\nThere are {_comments.Count} comments on this video. Here are the comments:\n");
        foreach (Comment c in _comments){
            c.Display();
        }
    }
}