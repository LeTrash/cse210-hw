// Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

// Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.

using System;


class Program
{
    static void Main(string[] args)
    {
        List<Video> _vid = new List<Video>();

        Video v1 = new Video();
        v1._title = "How to prepare a lobster dinner";
        v1._author = "David McKay";
        v1._length = 1500;

        Comment c1_v1 = new Comment();
        c1_v1._user_name = "AlphaSenpai34";
        c1_v1._comment = "Sebastian nooo!";
        v1.addcom(c1_v1);

        Comment c2_v1 = new Comment();
        c2_v1._user_name = "Crock_Duster_420";
        c2_v1._comment = "Where's the LAMB...SAUUUCE!!!";
        v1.addcom(c2_v1);

        Comment c3_v1 = new Comment();
        c3_v1._user_name = "Karen";
        c3_v1._comment = "Bone-Apple-Tea, ok emoji";
        v1.addcom(c3_v1);

        _vid.Add(v1);

        Video v2 = new Video();
        v2._title = "Age of Empires Playthrough ";
        v2._author = "DTM";
        v2._length = 4500;

        Comment c1_v2 = new Comment();
        c1_v2._user_name = "BeanSquash";
        c1_v2._comment = "Rookie move at 3:45";
        v2.addcom(c1_v2);

        Comment c2_v2 = new Comment();
        c2_v2._user_name = "Pudding";
        c2_v2._comment = "MeowMeowMeowMeowMeowMeowMeowMeowMeowMeowMeowMeowMeowMeowMeowMeowMeowMeow";
        v2.addcom(c2_v2);

        Comment c3_v2 = new Comment();
        c3_v2._user_name = "Billlllllllll";
        c3_v2._comment = "Das ist einer Klein und nicht gut";
        v2.addcom(c3_v2);

        _vid.Add(v2);

        Video v3 = new Video();
        v3._title = "Try not to Laugh Challenge";
        v3._author = "8BitRyan";
        v3._length = 2400;

        Comment c1_v3 = new Comment();
        c1_v3._user_name = "LeviJones43";
        c1_v3._comment = "hmmmmmmmmm";
        v3.addcom(c1_v3);

        Comment c2_v3 = new Comment();
        c2_v3._user_name = "PixelPenguinsGaming";
        c2_v3._comment = "And I said HEEEEEYEEEEEYEEEEYEEEAH";
        v3.addcom(c2_v3);

        Comment c3_v3 = new Comment();
        c3_v3._user_name = "andIOop";
        c3_v3._comment = "ChatGPT makes me laugh";
        v3.addcom(c3_v3);

        _vid.Add(v3);


        foreach (var i in _vid)
        {
            i.DisplayVideo();
            Console.WriteLine();
        }
    }
}