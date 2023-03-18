public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points)
    {
    }

    // public override int GetPoints()
    // {
    //     int result = 0;
    //     if (IsComplete())
    //     {
    //         result = _points;
    //     }
    //     return result;
    // }

    public override String ToString()
    {
        return $"This goal is complete {IsComplete}";
        //TODO: This is cruddy, make a better goal string
    }
}