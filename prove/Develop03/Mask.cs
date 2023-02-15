using System.IO;

public class Mask
{



    public void mask()
    {
        var random = new Random();
        List<string> test = new List<string>() { "one", "two", "three", "four" };
        List<string> modify = new List<string>();
        modify = test;
        int index = random.Next(modify.Count);
        Console.WriteLine(modify[index]);
        Console.WriteLine("Please write the complete scripture: ");

    }

}