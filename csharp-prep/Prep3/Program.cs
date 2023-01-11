using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        int mn = randomGen.Next(1,100);
        int goose = 0;
        int attempts = 0;

        while (goose != mn){
        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        goose = int.Parse(guess);

        if (goose < mn) {
            Console.WriteLine("Guess higher");
            attempts +=1;
        }
        else if (goose > mn){
            Console.WriteLine("Guess lower");
            attempts +=1;

        }
        else if (goose == mn){
            attempts +=1;
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {attempts} guesses.");

            break;
        }
 
        }

    }
}