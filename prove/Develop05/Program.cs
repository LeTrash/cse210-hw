using System;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary<String, Command> commands = new Dictrionary<String, Command>();


        Repository rep = new Mem();

        // commands["1"] = new CreateGoalCommand(rep);
        Goal simpleGoal = new SimpleGoal("Exercise.", "I want to exercise once, tmw.", 1000);
        Console.WriteLine(simpleGoal.ToString());

        rep.Add(simpleGoal);
        int numberOfGoals = rep.GetAll().Count;
        Console.WriteLine($"There are {numberOfGoals}in the system");
        simpleGoal.AddPoints(simpleGoal.GetPoints());
        simpleGoal.MarkComplete();
        Console.WriteLine(simpleGoal.ToString());

    }
}