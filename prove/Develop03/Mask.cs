using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

public class Mask
{
    private string rf;
    private string ph;

    // private int plonk;
    public void Setphrase(string phrase)
    {
        ph = phrase;
    }

    public void SetRef(string reff)
    {
        rf = reff;
    }




    public void mask()
    {
        string[] words = ph.Split(" ");

        List<string> modified = new List<string>(words);

        Random rand = new Random();


        // plonk = 0;
        Console.WriteLine("\nTo continue press enter. To exit to the menu, press any other key");
        var userInput = Console.ReadKey();

        while (userInput.Key == ConsoleKey.Enter)
        {
            Console.Write($"{rf} ");
            int num = rand.Next((modified.Count));

            string beans = "";
            // plonk += 1;

            foreach (int i in modified[num])
            {
                beans += "_";

            }
            modified[num] = beans;
            foreach (string ob in modified)
            {
                Console.Write($"{ob} ");

            }

            Console.WriteLine("\nTo continue press enter. To exit to the menu, press any other key");
            userInput = Console.ReadKey();
            Console.Clear();

        }
    }

}




//  Console.WriteLine("\nTo continue press enter. To exit to the menu, press any other key");
// var userInput = Console.ReadKey();
// (userInput.Key == ConsoleKey.Enter)

// Console.ReadKey();
// To read 1 key. You could then do something like this:

// string key = Console.ReadKey().Key.ToString();
// if(key.ToUpper() == "W")
//     Console.WriteLine("User typed 'W'!");
// else 
//     Console.WriteLine("User did not type 'W'");
// Or:

// if(key == "")
//     Console.WriteLine("User pressed enter!");
// else
//     Console.WriteLine("User did not press enter.");
// And if you do not care if the user types anything but presses enter after, you could just do:

// // Some code here
// Console.ReadLine();
// // Code here will be run after they press enter   

// ListData objlist = new ListData();

// int i_num = rand.Next(array.length-1)
// array[i_num] = "_____"
// Console.Write($" {word} ")
// }

// Console.WriteLine("To exit to the menu, press E. To continue, press any key");
// Console.ReadKey();
// string key = Console.ReadKey().Key.ToString();
// if (key.ToUpper() == "e")
//     Console.WriteLine("User typed 'E'!");
// else if (key.ToUpper() != "e")
//     Console.WriteLine("User did not type 'E'");

