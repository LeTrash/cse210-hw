using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int nn = 1;
        int sum = 0;
        List<int> numbers = new List<int>();

        while(nn != 0){
            Console.WriteLine("Enter number: ");
            string newNumb = Console.ReadLine();
            nn = int.Parse(newNumb); 
            numbers.Add(nn);

            if (nn == 0){
                numbers.RemoveAt(numbers.Count-1);
                break;
            }
        }

        for (int i =0; i< numbers.Count; i++){
            sum += numbers[i];
            // Console.WriteLine(numbers[i]);
        }

        Console.WriteLine($"The Sum is: {sum}");

        int avg = sum/numbers.Count;
        Console.WriteLine($"The average is : {avg}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

       






    }
}