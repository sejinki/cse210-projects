class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
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
                        PromptGenerator prompt = new PromptGenerator();

                        string prompt1 = prompt.GetRandomPrompt();
                        Console.WriteLine(prompt1);
                        Console.Write("> ");
                        string response = Console.ReadLine();

                        Entry newEntry = new Entry(prompt1, response);
                        journal.AddEntry(newEntry); 
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.WriteLine("What is the file name? ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;
                    case "4":
                        Console.Write("What is the file name? ");
                        String saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;
                    case "5":
                        Console.WriteLine("Til next time.");
                        break;
                    default:
                        Console.WriteLine("Not an option, try again!");
                        break;
                }


        }
    }
}