public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    { }



    public override String ToString()
    {
        String s = "";
        s += $"{GetName()}\n";
        s += $"{GetDesc()}\n";
        s += $"{GetPoints()}\n";
        s += $"{GetEarnedPoints()}\n";
        s += $"{IsComplete()}\n";
        return $"This simple goal is complete {s}";
        //TODO: This is cruddy, make a better goal string
    }

}