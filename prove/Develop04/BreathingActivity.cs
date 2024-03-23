public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe In...";
    private string _breatheOut = "Breathe Out...";

    public void DisplayBreathing(int time)
    {

        int breatheTime = 5;

        while (time != 0)
        {
            breatheTime = 5;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(_breatheIn);

            while (breatheTime != 0)
            {
                Console.Write(breatheTime);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                breatheTime -= 1;

                time -= 1;
            }

            breatheTime = 5;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(_breatheOut);

            while (breatheTime != 0)
            {
                Console.Write(breatheTime);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                breatheTime -= 1;

                time -= 1;
            }

        }

        DisplayEndMessage();
    }
}