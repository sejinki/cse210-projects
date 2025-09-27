using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> listOfnumbers = new List<int>();

        int userChoice = -1;

        while (userChoice != 0)
        {
            Console.Write("Enter a list of numbers, enter 0 when finished. ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice != 0)
            {
                listOfnumbers.Add(userChoice);
                Console.WriteLine(userChoice);
            }
        }

        int sum = 0;

        foreach (int num in listOfnumbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / listOfnumbers.Count;

        Console.WriteLine($"The average is: {average}");

        int largestNumber = listOfnumbers[0];
        foreach (int num in listOfnumbers)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}