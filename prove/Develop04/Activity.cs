public class Activity
{
    private string[] _descriptions = {"This Activity will guide you through a breathing exercise \nfor a chosen amount of time. This can help reduce stress. \n \nHow long, in seconds (10, 20, 30, etc.), would you like to run the activity? ",
                                    "This Activity will help you reflect on things that are happening in your life. \nYou will be presented with a prompt and you will be \nasked to ponder on the prompt. \n \nHow long, in seconds, would you like to run the activity? ",
                                    "This Activity will give you a prompt. You will then begin listing items by \ntyping them into the console. This will help you find more order in your life. \n \nHow long, in seconds, would you like to run the activity? "};

    public string ActivityName { private get; set; }
    public int Time { get; set; }
    public void DisplayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Hello! Welcome to the {ActivityName}.");
    }

    public void DisplayDescription(int choice)
    {
        Console.WriteLine(_descriptions[choice - 1]);
    }
    public void DisplayAnimation(int _time)
    {
        while (_time != 0)
        {
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);

            _time -= 1;
        }
        Console.Write("\b \b");
    }

    public void GetReady()
    {
        Console.WriteLine("\nGet Ready...");
        DisplayAnimation(3);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great job! Keep up the good work!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}