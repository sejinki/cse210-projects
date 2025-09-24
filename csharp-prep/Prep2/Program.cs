using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";

        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade >= 0)
        {
            letter = "F";

        }
        else
        {
            Console.Write("Please enter valid grade percentage. ");
        }

        Console.WriteLine($"Your grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed the course! ");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
        
    
    }
}