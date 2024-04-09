using System;

namespace ExerciseTracking
{
    public class RunningActivity : Activity
    {
        private double distance;

        public RunningActivity(int duration, double distance) : base(duration)
        {
            Distance = distance;
        }

        public double Distance
        {
            get { return distance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Distance cannot be negative.");
                }
                distance = value;
            }
        }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return Distance / Duration * 60; // Assuming duration is in minutes
        }

        public override double GetPace()
        {
            return Duration / Distance;
        }

        public override string GetSummary()
        {
            return $"{DateTime.Now:dd MMM yyyy} Running ({Duration} min): Distance {Distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
    }
}
