using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Menu Options:\n1. Breathing activity\n2. Reflecting activity\n3.Listing activity\n4. Quit");
            Console.WriteLine("Please select a choice from the menu: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Breathing breath = new Breathing();
                breath.breathing();
                breath.GetSeconds();
            }
            else if (choice == 2)
            {
                Reflection reflect = new Reflection();
                reflect.reflection();
                reflect.GetSeconds();
            }
            else if (choice == 3)
            {
                Listing list = new Listing();
                list.listing();
                list.GetSeconds();
            }


        } while (choice != 4);

    }

}