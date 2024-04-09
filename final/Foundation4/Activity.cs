using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private int duration;

        public Activity(int duration)
        {
            Duration = duration;
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration cannot be negative.");
                }
                duration = value;
            }
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();
        public abstract string GetSummary();
    }
}
