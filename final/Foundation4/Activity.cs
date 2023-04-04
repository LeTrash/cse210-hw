
public class Activity
{
    private DateTime date;
    protected int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        string summary = date.ToString("dd MMM yyyy");
        summary += " " + this.GetType().Name + " (" + length.ToString() + " min)";
        summary += " - Distance: " + GetDistance().ToString("0.0") + " km";
        summary += ", Speed: " + GetSpeed().ToString("0.0") + " kph";
        summary += ", Pace: " + GetPace().ToString("0.0") + " min/km";
        return summary;
    }
}