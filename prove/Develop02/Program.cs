using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit ");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            string journalChoiceMenu = Console.ReadLine();
            
            if (int.TryParse(journalChoiceMenu, out choice))

                switch (journalChoiceMenu)
                {
                    case "1":
                        Console.WriteLine("hi");
                        break;
                    case "2":
                        Console.WriteLine("hi");
                        break;
                    case "3":
                        Console.WriteLine("hi");
                        break;
                    case "4":
                        Console.WriteLine("hi");
                        break;
                    case "5":
                        Console.WriteLine("hi");
                        break;
                    default:
                        Console.WriteLine("hi");
                        break;
                }


        }
    }
}