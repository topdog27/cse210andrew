using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            return Points;
        }

        public override string GetDetailsString()
        {
            return $"{Name} ({Description})";
        }

        public override string GetSaveData()
        {
            return $"EternalGoal;{Name};{Description};{Points}";
        }
    }
}
