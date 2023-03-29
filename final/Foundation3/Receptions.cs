public class Reception : events
{

    public void DisplayFull()
    {
        Console.WriteLine($"{_event} - {_title}: '{_desc}' - On {_date} at {_time}, {_add}. Please make sure to reply to this email in order to RSVP.");
        Console.WriteLine();
    }
}