using System;

namespace GameLogic
{
    [Serializable]
    public class BuildingStructure
    {
        public int DaysTillEnd { get; set; } = 0;
        public Occupation BelongsToOccup { get; set; }
    }
}
