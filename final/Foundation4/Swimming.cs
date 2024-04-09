using System;

namespace ExerciseTracking
{
    public class SwimmingActivity : Activity
    {
        private int laps;

        public SwimmingActivity(int duration, int laps) : base(duration)
        {
            Laps = laps;
        }

        public int Laps
        {
            get { return laps; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Laps cannot be negative.");
                }
                laps = value;
            }
        }

        public override double GetDistance()
        {
            return Laps * 50 / 1000; // 50 meters per lap, converting to kilometers
        }

        public override double GetSpeed()
        {
            return GetDistance() / Duration * 60; // Assuming duration is in minutes
        }

        public override double GetPace()
        {
            return Duration / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{DateTime.Now:dd MMM yyyy} Swimming ({Duration} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
        }
    }
}
