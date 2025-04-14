using System;

namespace ExerciseTracking
{
    public class CyclingActivity : Activity
    {
        private double _averageSpeed;

        public CyclingActivity(DateTime date, int duration, double averageSpeed)
            : base(date, duration)
        {
            _averageSpeed = averageSpeed;
        }

        public override string ActivityName => "Cycling";
        public override double GetSpeed() => _averageSpeed;
        public override double GetDistance() => _averageSpeed * Duration / 60.0;
        public override double GetPace()
        {
            double distance = GetDistance();
            return distance != 0 ? (double)Duration / distance : 0;
        }
    }
}
