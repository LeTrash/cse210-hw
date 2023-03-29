// a Video that has the responsibility to track the title, author, and length (in seconds) of the video.

using System;
public class Video
{

    public string _title = "";

    public string _author = "";

    public int _length;

    public List<Comment> _comments = new List<Comment>();


    public void addcom(Comment com)
    {
        _comments.Add(com);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}. Runtime: {_length}");
        foreach (Comment com in _comments)
        {
            com.DisplayComment();
        }
    }


}