using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        public int BonusPoints { get; private set; }
        public int TargetCount { get; private set; }
        public int CurrentCount { get; private set; }

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
            : base(name, description, points)
        {
            TargetCount = targetCount;
            BonusPoints = bonusPoints;
            CurrentCount = 0;
        }

        public override int RecordEvent()
        {
            if (!IsComplete)
            {
                CurrentCount++;
                if (CurrentCount >= TargetCount)
                {
                    SetCompletion(true);
                    return Points + BonusPoints;
                }
                return Points;
            }
            return 0;
        }

        public override string GetDetailsString()
        {
            string status = IsComplete ? "[X]" : "[ ]";
            return $"{status} {Name} ({Description}) -- Completed: {CurrentCount}/{TargetCount}";
        }

        public override string GetSaveData()
        {
            return $"ChecklistGoal;{Name};{Description};{Points};{TargetCount};{BonusPoints};{CurrentCount};{IsComplete}";
        }

        public void SetCurrentCount(int count, bool isComplete)
        {
            CurrentCount = count;
            SetCompletion(isComplete);
        }
    }
}


