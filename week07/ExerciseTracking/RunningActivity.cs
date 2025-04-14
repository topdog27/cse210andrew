using System;

namespace ExerciseTracking
{
    public class RunningActivity : Activity
    {
        private double _distance;

        public RunningActivity(DateTime date, int duration, double distance)
            : base(date, duration)
        {
            _distance = distance;
        }

        public override string ActivityName => "Running";
        public override double GetDistance() => _distance;
        public override double GetSpeed() => (_distance / Duration) * 60;
        public override double GetPace() => _distance != 0 ? (double)Duration / _distance : 0;
    }
}
