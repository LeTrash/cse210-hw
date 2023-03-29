public class events
{
    public string _event = "";

    public string _title = "";
    public string _desc = "";

    public string _date = "";

    public string _time = "";

    public string _add = "";

    public void DisplayDetails()
    {
        Console.WriteLine($"{_event} - {_title}: '{_desc}' - On {_date} at {_time}, {_add}");
        Console.WriteLine();
    }

    public void DisplaySmol()
    {
        Console.WriteLine($"{_event} - {_title} -{_date}");
        Console.WriteLine();
    }

}