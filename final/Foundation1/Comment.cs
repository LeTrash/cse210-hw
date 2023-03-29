//  A comment should be defined by the Comment class which has the responsibility for tracking both the name of the person who made the comment and the text of the comment.
using System;

public class Comment
{
    public string _user_name = "";

    public string _comment = "";

    public Comment()
    {
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_user_name} commented : '{_comment}'");
    }

}