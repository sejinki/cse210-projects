public class Breathing : Activity
{
    public Breathing()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        StartMessage();

        int duration = GetDuration();

        while (duration > 0)
        {
            Console.Write("\nBreathe in ... ");
            PauseWithTimer(4);
            Console.Write("\nNow Breathe out ... ");
            PauseWithTimer(6);

            duration -= 10;
        }

        EndMessage();
    }
    

}