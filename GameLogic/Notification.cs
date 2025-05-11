using System;

namespace GameLogic
{
    [Serializable]
    public class Notification
    {
        public string Name { get; set; }
        public int Count { get; set; } = 1;
        public override string ToString()
        {
            if (Count > 1)
            {
                return $"{Name}({Count})(Day {Fortress.CurrentDay})";
            }
            else
            {
                return $"{Name}(Day {Fortress.CurrentDay})";
            }
        }
    }
}
