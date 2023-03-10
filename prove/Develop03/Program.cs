using System;
using System.Threading;
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
class Program
{
    static void Main(string[] args)
    {
        // List<string> original = new List<string>();

        int choice;
        Console.WriteLine("Welcome to the Scripture Program!");
        Console.WriteLine("This program aims to help you memorize a scripture of your choosing");

        do
        {
            Console.WriteLine("Please select a book to pick from: \n1. Book of Mormon\n2.Doctrine and Covenants\n3.New Testament\n4.Old Testament\n5.Pearl of Great Price\n6.Quit");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                string filepath = "https://raw.githubusercontent.com/bcbooks/scriptures-json/master/flat/book-of-mormon-flat.json";
                Json bom = new Json();
                bom.readToFile(filepath);
                Mask mask = new Mask();
                Thread.Sleep(5000);
                mask.Setphrase(bom.Getphrase());
                mask.SetRef(bom.Getreff());
                mask.mask();
            }
            else if (choice == 2)
            {
                string filepath = "https://raw.githubusercontent.com/bcbooks/scriptures-json/master/flat/doctrine-and-covenants-flat.json";
                Json dnc = new Json();
                dnc.readToFile(filepath);
                Mask mask = new Mask();
                Thread.Sleep(5000);
                mask.Setphrase(dnc.Getphrase());
                mask.SetRef(dnc.Getreff());
                mask.mask();

            }
            else if (choice == 3)
            {
                string filepath = "https://raw.githubusercontent.com/bcbooks/scriptures-json/master/flat/new-testament-flat.json";
                Json nt = new Json();
                nt.readToFile(filepath);
                Mask mask = new Mask();
                Thread.Sleep(5000);
                mask.Setphrase(nt.Getphrase());
                mask.SetRef(nt.Getreff());
                mask.mask();

            }
            else if (choice == 4)
            {
                string filepath = "https://raw.githubusercontent.com/bcbooks/scriptures-json/master/flat/old-testament-flat.json";
                Json ot = new Json();
                ot.readToFile(filepath);
                Mask mask = new Mask();
                Thread.Sleep(5000);
                mask.Setphrase(ot.Getphrase());
                mask.SetRef(ot.Getreff());
                mask.mask();

            }
            else if (choice == 5)
            {
                string filepath = "https://raw.githubusercontent.com/bcbooks/scriptures-json/master/flat/pearl-of-great-price-flat.json";
                Json pog = new Json();
                pog.readToFile(filepath);
                Mask mask = new Mask();
                Thread.Sleep(5000);
                mask.Setphrase(pog.Getphrase());
                mask.SetRef(pog.Getreff());
                mask.mask();

            }
        } while (choice != 6);
    }
}