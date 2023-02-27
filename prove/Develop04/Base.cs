public class Base
{

    public void GetSeconds()
    {
        int time;
        Console.WriteLine("How long, in seconds, would you like for your session?");
        time = Convert.ToInt32(Console.ReadLine());
    }

    public string displayprompt(string[] _prompts)
    {
        Random rand = new Random();
        int num = rand.Next(_prompts.Count);
        string prmt = _prompts[num];

        Console.Write("Here is a suggested prompt:");
        Console.WriteLine(prmt);
        return prmt;
    }


}