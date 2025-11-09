using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment b1 = new Assignment("Andrew Smith", "Programming with classes");


        Console.WriteLine(b1.GetSummary());

        MathAssignment m1 = new MathAssignment("Andrew Smith", "Fractions", "7.3", "8-19");

        Console.WriteLine(m1.GetSummary());

        Console.WriteLine(m1.GetHomeworkList());

        WritingAssigment w1 = new WritingAssigment("Andrew Smith", "European History", "The Causes of World War II");
        
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}