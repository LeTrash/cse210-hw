public class Lectures : events
{

    public string _speaker = "";
    public int _cap;

    public void DisplayFull()
    {
        Console.WriteLine($"{_event} - {_title}: '{_desc}' - On {_date} at {_time}, {_add}. {_speaker} will be presenting. Only {_cap} capacity");
        Console.WriteLine();
    }

}