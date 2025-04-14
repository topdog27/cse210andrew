using System;

namespace ExerciseTracking
{
    public class SwimmingActivity : Activity
    {
        private int _laps;

        public SwimmingActivity(DateTime date, int duration, int laps)
            : base(date, duration)
        {
            _laps = laps;
        }

        public override string ActivityName => "Swimming";
        public override double GetDistance() => _laps * 50.0 / 1000.0;
        public override double GetSpeed() => (GetDistance() / Duration) * 60;
        public override double GetPace()
        {
            double distance = GetDistance();
            return distance != 0 ? (double)Duration / distance : 0;
        }
    }
}
