using System;

namespace GameLogic
{
    [Serializable]
    public class Race
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int HungerRate { get; set; }
        public int MaxHunger { get; set; }
        public int Beauty { get; set; }
        public int Strength { get; set; } = 1;
        public int Intelligence { get; set; } = 1;

        public override string ToString()
        {
            return Name;
        }
    }
}
