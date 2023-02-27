public class Reflection : Base
{
    public string _response;
    public string[] _prompts = { "Think of a time when you had an allergic reaction", "Think of a time you've puked in front of everyone", "Think of a time where you cried. Why?", "Think of a time where you had an out of body experience", "Think of a time where you had a nightmare" };

    public string[] _ponder = { "Why was this experience meaningful to you?", "What is your favorite thing about this experience?", "What did you learn about yourself through this experience?" };

    public void reflection()
    {

        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }







};