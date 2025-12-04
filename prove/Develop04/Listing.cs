public class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "List as many things as you are grateful for.",
        "List as many personal strengths as you can think of.",
        "List as many people who have positively influenced your life."
    };

    public Listing()
        : base("Listing", "This activity helps you focus on positive aspects of your life by listing things in response to a prompt.")
    {

    }
    
    public void RunActivity()
    {
        StartMessage();

        int duration = GetDuration();
        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses you can to the following prompt: {prompt}");
        Console.WriteLine("You may begin in: ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
        Console.Write("> ");
        string input = Console.ReadLine();
        }
        EndMessage();
    }

}