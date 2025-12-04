using System.Security.Cryptography.X509Certificates;

public class Activity
{
    public string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity. \n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for this session? ");

        _duration = int.Parse(Console.ReadLine());

        Console.Write("\nGet ready... ");
        PauseWhileSpinner(3);

    }

    public void EndMessage()
    {
        Console.Write("\nWell Done!! ");
        PauseWhileSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        PauseWhileSpinner(3);
        Console.Clear();

    }

    public int GetDuration()
    {
        return _duration;
    }


    public void PauseWhileSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");        
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500); 
            Console.Write("\b \b");

        }

    }

    public void PauseWithTimer(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }

}