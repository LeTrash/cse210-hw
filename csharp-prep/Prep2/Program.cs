using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string student_grade = Console.ReadLine();
        int number = int.Parse(student_grade);

        string letter = "";

        if (number >= 90){
            letter ="A";
        }
        else if (number >= 80){
            letter = "B";
        }
        else if (number >= 70){
            letter = "C";
        }
        else if (number >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if(number >= 70){
            Console.WriteLine("You passed the class! Congratulations!!");
        }
        else{
            Console.WriteLine("So sorry but you did not pass the class. I'm sure if you keep trying you can do it!");
        }

    }
}