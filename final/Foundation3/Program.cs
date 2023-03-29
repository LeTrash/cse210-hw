using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lc = new Lectures();
        lc._event = "Lecture";
        lc._title = "Danger of Global Warming";
        lc._desc = "A discussion about the dangers of Global Warming";
        lc._date = "November 20th, 2024";
        lc._time = "4:00 PM";
        lc._add = "4401 Cherry Hill Rd, Arlington VA";
        lc._speaker = "Albert Thomas";
        lc._cap = 300;
        lc.DisplayFull();
        lc.DisplayDetails();
        lc.DisplaySmol();

        Outdoor od = new Outdoor();
        od._event = "OutDoor";
        od._title = "SWE Tea Party";
        od._desc = "A gathering for the members of SWE ";
        od._date = "March 30th, 1999";
        od._time = "12:00 AM";
        od._add = "lame street";
        od._weather = "Sunny with a chance of MeatBalls";
        od.DisplayFull();
        od.DisplayDetails();
        od.DisplaySmol();

        Reception rp = new Reception();
        rp._event = "Reception";
        rp._title = "Divorce Reception";
        rp._desc = "A gathering to celebrate Milly and Billy getting divorced.";
        rp._date = "Yes Please";
        rp._time = "5:00 AM";
        rp._add = "Your moms place";
        rp.DisplayFull();
        rp.DisplayDetails();
        rp.DisplaySmol();

    }

    // _event = "";

    // public string _title = "";
    // public string _desc = "";

    // public string _date = "";

    // public string _time = "";

    // public string _add
}