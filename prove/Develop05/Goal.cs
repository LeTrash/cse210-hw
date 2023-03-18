public class Goal
{

    private String _name = "";
    private String _desc = "";
    private int _points = 0;
    private int _earned = 0;
    private Boolean _complete = false;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetDesc()
    {
        return _desc;
    }

    public int GetPoints()
    {
        return _points;
    }
    public int GetEarnedPoints()
    {
        return _earned;
    }

    public virtual void MarkComplete()
    {
        _complete = true;
    }

    public virtual void MarkIncomplete()
    {
        _complete = false;
    }
    public virtual void ReportPorgress()
    {
        //Different for each goal

    }

    public virtual void AddPoints(int points)
    {
        _earned += points;
    }
    public bool IsComplete()
    {
        return _complete;
    }

    public override String ToString()
    {
        return $"This goal is complete {_complete}";
        //TODO: This is cruddy, make a better goal string
    }
}