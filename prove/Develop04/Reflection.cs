public class Reflection : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you did something really difficult.",
        "Think of a time you overcame a challenge with a friend or family member",
        "Think of time when you felt a burst of hope."
    };

    private List<string> _questions = new List<string>()
    {
        "> Why was this experience meaningful to you?",
        "> What did you learn from this experience?",
        "> How did this experience change you?",
        "> What made this experience memorable?",
        "> What could you do in the future to apply what you learned?"
    };

    public Reflection()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){}

    public void RunActivity()
    {
        StartMessage();

        int duration = GetDuration();
        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        while (duration > 0)
        {
            string question = _questions[random.Next(_questions.Count)];

            Console.Write($"\n{question} ");
            PauseWhileSpinner(5);
            duration -= 5;
        }

        EndMessage();
    }



}