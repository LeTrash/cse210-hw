public class Listing : Base
{

    public string[] _prompts = { "Who are people you respect?", "What do you like about yourself?", "What kind of people do you keep close to you?", "When do you feel at peace?", "What attributes are most important in a person?" };



    public void listing()
    {

        Console.Clear();

        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void write()
    {
        Console.WriteLine("Please list as many items corresponding to the prompt: ");
        Console.ReadLine();
    }





};