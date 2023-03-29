using System;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<String, Command> commands = new Dictionary<String, Command>();
        commands['0'] = new ViewMenu();


        string choice = "";
        while (choice != 'q')
        {
            commands["0"].Execute;
            choice = Console.ReadLine();
            if (choice != 'q')
            {
                Command command = commands(choice);
                command.Execute();
            }
        }
    }
}