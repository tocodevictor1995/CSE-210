public class ListingActivity : Activity
{
    private string[] _prompts = {"When did you feel the spirit today?",
                                "Who are the people that you love most?",
                                "What do you do to stay productive?",
                                "What are some things that you can do to help others?",
                                "What are you grateful for?"};
    private int _entryCount = 0;

    public void DisplayListing(int time)
    {
        var random = new Random();
        int index = random.Next(_prompts.Count());


        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine($"--- {_prompts[index]} ---\n");

        YouMayBegin();

        Write(time);

        DisplayEndMessage();
    }

    private void YouMayBegin()
    {
        int time = 5;
        Console.Write("You may begin in:  ");

        while (time != 0)
        {
            Console.Write("\b");
            Console.Write(time);
            Thread.Sleep(1000);

            time -= 1;
        }

        Console.Write("\b \b");
        Console.WriteLine();
    }

    private void Write(int time)
    {
        _entryCount = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            _entryCount += 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {_entryCount} items!");

    }
}