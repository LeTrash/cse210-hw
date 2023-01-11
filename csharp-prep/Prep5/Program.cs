using System;

class Program
{
    static void Main(string[] args)
    {

    string userName = PromptUserName();
    int userNumber = PromptUserNumber();

    int squar = SquareNumber(userNumber);

    DisplayResult(userName, squar); 


    }
        static void DisplayMessage(){
            Console.WriteLine("Welcome to the Program!");
        }

       static string PromptUserName(){
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        
        static int PromptUserNumber(){
            Console.WriteLine("Please enter an integer: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber); 
            return number;


        }

        static int SquareNumber(int number){
            int squar = number * number;
            return squar;
        }

        static void DisplayResult (string userName, int squar){
            Console.WriteLine($"{userName}, the square of your number is {squar}");
        }


}