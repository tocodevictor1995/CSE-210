using System;

namespace ExerciseTracking
{
    public class CyclingActivity : Activity
    {
        private double speed;

        public CyclingActivity(int duration, double speed) : base(duration)
        {
            Speed = speed;
        }

        public double Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Speed cannot be negative.");
                }
                speed = value;
            }
        }

        public override double GetDistance()
        {
            return Speed * Duration / 60; // Assuming duration is in minutes
        }

        public override double GetSpeed()
        {
            return Speed;
        }

        public override double GetPace()
        {
            return 60 / Speed;
        }

        public override string GetSummary()
        {
            return $"{DateTime.Now:dd MMM yyyy} Cycling ({Duration} min): Distance {GetDistance()} miles, Speed {Speed} mph, Pace: {GetPace()} min per mile";
        }
    }
}
