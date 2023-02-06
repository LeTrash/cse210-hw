using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program.");
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        int choice;
        string fileName = "Journal.txt";

        do {
            Console.WriteLine("Please select one of the following choices by selecting it's corresponding number");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1){
                Log write = new Log();
                string prompt = write.displayprompt();
                write._response = Console.ReadLine();
                write._dateTime = dateText;
                write.SaveFile(prompt);
                
            }
            else if (choice == 2){
                var entries = File.ReadLines(fileName);
                foreach(string entry in entries){
                    Console.WriteLine(entry);
                }
            }
            else if (choice == 3){
                Scribe load = new Scribe();
                var filenam = load.askfile();
                load.replace(filenam, fileName);
                
            }
            else if(choice == 4){
                Save sav = new Save();
                sav._journalEntries = fileName;
                Console.WriteLine("Input the file you would like to use:");
                sav._newfilenam = Console.ReadLine();
                sav.SaveJournal(fileName);
            }

        
        }while(choice != 5);
        

        

    }
}