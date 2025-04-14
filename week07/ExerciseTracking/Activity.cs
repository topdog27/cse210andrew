using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _duration;

        public Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public DateTime Date => _date;
        public int Duration => _duration;

        public abstract string ActivityName { get; }
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {ActivityName} ({_duration} min) - " +
                   $"Distance: {GetDistance():F1} km, " +
                   $"Speed: {GetSpeed():F1} kph, " +
                   $"Pace: {GetPace():F1} min per km";
        }
    }
}
