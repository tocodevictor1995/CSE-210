using System;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Library exerciseLibrary = new Library();

            while (true)
            {
                DisplayMenu(exerciseLibrary);
            }
        }

        static void DisplayMenu(Library exerciseLibrary)
        {
            Console.WriteLine("Exercise Tracking System");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Add Running Activity");
            Console.WriteLine("2. Add Cycling Activity");
            Console.WriteLine("3. Add Swimming Activity");
            Console.WriteLine("4. Display Activities Summary");
            Console.WriteLine("5. Exit");
            Console.WriteLine("------------------------");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter duration (in minutes): ");
                    int runningDuration = int.Parse(Console.ReadLine());
                    Console.Write("Enter distance (in miles): ");
                    double runningDistance = double.Parse(Console.ReadLine());
                    exerciseLibrary.AddRunningActivity(runningDuration, runningDistance);
                    break;
                case "2":
                    Console.Write("Enter duration (in minutes): ");
                    int cyclingDuration = int.Parse(Console.ReadLine());
                    Console.Write("Enter speed (in mph): ");
                    double cyclingSpeed = double.Parse(Console.ReadLine());
                    exerciseLibrary.AddCyclingActivity(cyclingDuration, cyclingSpeed);
                    break;
                case "3":
                    Console.Write("Enter duration (in minutes): ");
                    int swimmingDuration = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of laps: ");
                    int swimmingLaps = int.Parse(Console.ReadLine());
                    exerciseLibrary.AddSwimmingActivity(swimmingDuration, swimmingLaps);
                    break;
                case "4":
                    exerciseLibrary.DisplayActivitiesSummary();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
