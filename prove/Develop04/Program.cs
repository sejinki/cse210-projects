using System;

class Program
{
    static void Main(string[] args)
    {
         //Scripture scripture = new Scripture();
        int choice = -1;

        while (choice != 4)
        {
            Console.WriteLine("~~ Mindfulness ~~");
            Console.WriteLine("Menu Options: \n1. Start Breathing activity\n2. Start Reflecting activity\n3. Start Listening activity\n4. Quit ");
            Console.Write("Select a choice from the Menu: ");
            string ChoiceMenu = Console.ReadLine();

            if (int.TryParse(ChoiceMenu, out choice))

                switch (choice)
                {
                    case 1:
                        new Breathing().Run();
                        break;
                    case 2:
                        new Reflection().RunActivity();
                        break;
                    case 3:
                        new Listing().RunActivity();
                        break;
                    case 4:
                        break;    
                    default:
                        Console.WriteLine("Not an option, try again!");
                        break;
                }
        }
    }
}
