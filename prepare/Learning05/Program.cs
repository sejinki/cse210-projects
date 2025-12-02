using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Red", 3);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Blue", 4, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Green", 6);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }

}
    // {
    //     DisplayWelcomeMessage();

    //     string userName = PromptUserName();
    //     int favNumber = PromptUserNumber();

    //     int birthYear;
    //     PromptUserBirthYear(out birthYear);

    //     int squaredNumber = SquareNumber(favNumber);


    //     DisplayResult(userName, squaredNumber, birthYear);
    // }
    // static void DisplayWelcomeMessage()
    // {
    //     Console.WriteLine("Welcome to the program! ");
    // }

    // static string PromptUserName()
    // {
    //     Console.Write("Please enter your name: ");
    //     string name = Console.ReadLine();

    //     return name;
    // }

    // static int PromptUserNumber()
    // {
    //     Console.Write("Please enter your favorite number: ");
    //     int favNumber = int.Parse(Console.ReadLine());

    //     return favNumber;
    // }

    // static void PromptUserBirthYear(out int birthYear)
    // {
    //     Console.Write($"Please enter the year you were born: ");
    //     birthYear = int.Parse(Console.ReadLine());
    // }

    // static int SquareNumber(int favNumber)
    // {
    //     int squareNumber = favNumber * favNumber;

    //     return squareNumber;
    // }

//     static void DisplayResult(string name, int square, int birthYear)
//     {
//         Console.WriteLine($"{name}, the square of your number is {square}.");
//         Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
//     }
// }