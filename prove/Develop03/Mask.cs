using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

public class Mask
{

    private string ph;

    public void Setphrase(string phrase)
    {
        ph = phrase;
    }

    public void mask()
    {
        Console.WriteLine("1");
        string[] words = ph.Split(" ");
        Console.WriteLine("2");

        List<string> modified = new List<string>(words);

        Random rand = new Random();
        Console.WriteLine("4");

        int num = rand.Next(modified.Count);

        string beans = "";

        foreach (int i in modified[num])
        {
            beans += "_";


        }
        modified[num] = beans;
        foreach (string ob in modified)
        {
            Console.WriteLine(ob);

        }

    }

}

// ListData objlist = new ListData();

// int i_num = rand.Next(array.length-1)
// array[i_num] = "_____"
// Console.Write($" {word} ")
// }