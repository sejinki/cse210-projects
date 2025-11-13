using System;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("~~ Scripture Memorizer ~~");
        Console.WriteLine("Please press enter to continue or type 'quit' to finish: ");


        List<Scripture> scriptures = LoadFromFile("scriptures.txt");

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue more words or type 'quit' to finish. ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords();
            }
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden or user quit. Program ended.");



    }

    static List<Scripture> LoadFromFile(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 2)
                {
                    string reference = parts[0];
                    string text = parts[1];
                    Scripture s = new Scripture(reference, text);
                    scriptures.Add(s);
                }
            }
        }
        else
        {
            Console.WriteLine($"File not found: {fileName}");
        }
        return scriptures;
    }

}