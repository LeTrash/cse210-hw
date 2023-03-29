using System;
using System.Text;
public class ViewMenu : Command
{
    public override void Execute()
    {
        StringBuilder s = new StringBuilder();
        s.AppendLine("Menu");
        s.AppendLine("1. Add Goal");
        s.AppendLine("2. Remove Goal");
        s.AppendLine("3. ?");
        s.AppendLine("q. bye, this is lame");
        s.AppendLine("Make a choice");

        Console.WriteLine(s.ToString());




    }
}