public class Breathing : Base
{

    public void breathing()
    {

        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");



    }

    public void displaybreath()
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        List<string> animation = new List<string>();
        animation.Add("Breath in        ");
        animation.Add("( ◡ ‿ ◡ ) 1");
        animation.Add("( ◡ ▿ ◡ ) 2");
        animation.Add("( ◡ ▽ ◡ ) 3");
        animation.Add("( ˘ ᗢ ˘ ) 4");
        animation.Add("( ˘ ︶ ˘ )        ");
        animation.Add("Breath out       ");
        animation.Add("( ˘ ︶ ˘ )   ");
        animation.Add("( ˘ 〇 ˘ )  1");
        animation.Add("( ◡ ｏ ◡ )  2");
        animation.Add("( ◡ ｡ ◡ )   3");
        animation.Add("( ◡ ‿ ◡ )   4");




        while (DateTime.Now < endTime)
        {

            foreach (string s in animation)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\r");
                if (DateTime.Now > endTime)
                {
                    break;
                }
            }
        }

    }






};