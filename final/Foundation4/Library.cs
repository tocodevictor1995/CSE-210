using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    public class Library
    {
        private List<Activity> activities;

        public Library()
        {
            activities = new List<Activity>();
        }

        public void AddRunningActivity(int duration, double distance)
        {
            RunningActivity runningActivity = new RunningActivity(duration, distance);
            activities.Add(runningActivity);
        }

        public void AddCyclingActivity(int duration, double speed)
        {
            CyclingActivity cyclingActivity = new CyclingActivity(duration, speed);
            activities.Add(cyclingActivity);
        }

        public void AddSwimmingActivity(int duration, int laps)
        {
            SwimmingActivity swimmingActivity = new SwimmingActivity(duration, laps);
            activities.Add(swimmingActivity);
        }

        public void DisplayActivitiesSummary()
        {
            Console.WriteLine("Activities Summary:");
            Console.WriteLine("-------------------");
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
