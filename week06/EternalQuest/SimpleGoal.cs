using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            if (!IsComplete)
            {
                SetCompletion(true);
                return Points;
            }
            return 0;
        }

        public override string GetSaveData()
        {
            return $"SimpleGoal;{Name};{Description};{Points};{IsComplete}";
        }
    }
}
