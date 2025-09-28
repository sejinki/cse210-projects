using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squaredNumber = SquareNumber(favNumber);


        DisplayResult(userName, squaredNumber, birthYear);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int favNumber)
    {
        int squareNumber = favNumber * favNumber;

        return squareNumber;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
    }
}