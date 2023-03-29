public class Outdoor : events
{

    public string _weather = "";

    public void DisplayFull()
    {
        Console.WriteLine($"{_event} - {_title}: '{_desc}' - On {_date} at {_time}, {_add}. The weather forecast is {_weather} ");
    }

}