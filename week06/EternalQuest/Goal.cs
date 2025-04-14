using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int Points { get; protected set; }
        protected bool IsComplete { get; set; }

        public Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
            IsComplete = false;
        }

        public abstract int RecordEvent();

        public virtual string GetDetailsString()
        {
            string status = IsComplete ? "[X]" : "[ ]";
            return $"{status} {Name} ({Description})";
        }

        public abstract string GetSaveData();

        public void SetCompletion(bool completed)
        {
            IsComplete = completed;
        }
    }
}
