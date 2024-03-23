public class ReflectingActivity : Activity
{
    private string[] _prompts = {"Think of a time when you felt lost",
                                "Think of a time when you needed help",
                                "Think of a time when you felt loved",
                                "Think of a time when you felt the spirit",
                                "Think of a time when you felt happy"};

    private string[] _questions = {"How did you know that you had been found?",
                                    "Who helped you? Why do you think they helped you?",
                                    "What made you feel loved?",
                                    "How did the spirit influence your life for good?",
                                    "What made you feel happy? Why?"};

    public void DisplayReflection(int time)
    {
        var random = new Random();
        int index = random.Next(_prompts.Count());

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_prompts[index]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"> {_questions[index]}");

        DisplayAnimation(time);

        DisplayEndMessage();
    }
}