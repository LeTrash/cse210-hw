public class Base
{
    private int time = 0;

    private string act = "";
    public void GetSeconds()
    {
        int time;
        Console.WriteLine("How long, in seconds, would you like for your session?");
        time = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }

    public string displayprompt(string[] _prompts)
    {
        List<string> list = new List<string>();

        list.AddRange(_prompts);

        Random rand = new Random();
        int num = rand.Next(list.Count);
        string prmt = list[num];

        Console.Write("Here is a suggested prompt: ");
        Console.WriteLine(prmt);
        return prmt;
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
        animation.Add(" _(oᵔᴗᵔo)_    Loading   ");
        animation.Add(" (/o^▽^o)/ ☆  Loading .  ");
        animation.Add(" _(oᵔᴗᵔo)_    Loading . . ");
        animation.Add("☆ \\(o^▽^o\\)   Loading . . .");

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

        Console.WriteLine("Great Job!");

        Console.WriteLine($"You have completed {time} seconds of the {act} activity");
    }




}

// 〇 ｏ｡
//( ◡ ‿ ◡ )
//( ◡ ｡ ◡ )
//( ◡ ｏ ◡ )
//( ˘ 〇 ˘ )
//( ◡ ｏ ◡ )
//( ◡ ｡ ◡ )
