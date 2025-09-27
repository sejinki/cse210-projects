using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());

        //int magicNumber = 4;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        while (guessNumber != magicNumber)
        {
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("higher");
            }

            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("you guessed it!");
        Console.WriteLine();

        //Console.Write("Do you want to play again?");


    }
}