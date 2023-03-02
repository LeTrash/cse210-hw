public class Base
{
    protected int time;

    public string act = "";

    protected int cot;
    public void GetSeconds()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        time = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }

    public void displayprompt(string[] _prompts)
    {
        List<string> list = new List<string>();

        list.AddRange(_prompts);

        Random rand = new Random();
        int num = rand.Next(list.Count);
        string prmt = list[num];

        Console.Write("Here is a suggested prompt: ");
        Console.WriteLine(prmt);
    }

    public void displayCountDown()
    {
        //     for (int i = 5; i > 0; i--)
        //     {
        //         Console.Clear();
        //         Console.Write(i);
        //         Thread.Sleep(1000);
        //     }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(12);

        List<string> animation = new List<string>();
        animation.Add(" _(oᵔᴗᵔo)_  ");
        animation.Add(" (/o^▽^o)/ ☆  ");
        animation.Add(" _(oᵔᴗᵔo)_    ");
        animation.Add("☆ \\(o^▽^o\\) ");

        while (DateTime.Now < endTime)
        {
            foreach (string s in animation)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\r");

            }
        }

    }

    public void displaymessage(int choice)
    {
        if (choice == 1)
        {
            act = "Breathing";
        }
        else if (choice == 2)
        {
            act = "Reflection";
        }
        else if (choice == 3)
        {
            act = "Listing";
        }

        Console.WriteLine("\rGreat Job!      ");

        Console.WriteLine($"You have completed {time} seconds of the {act} activity");
    }

    public void space()
    {
        Console.WriteLine("Once you are ready, press enter to continue.");
        var userInput = Console.ReadKey();
        while (userInput.Key != ConsoleKey.Enter)
        {
            Console.WriteLine("Once you are ready, press enter to continue.");
            userInput = Console.ReadKey();
        }

    }

}


