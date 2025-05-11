using System;
using System.Collections.Generic;

namespace GameLogic
{
    [Serializable]
    public class Occupation
    {
        public string Name { get; set; }
        public int StrengthAmplifier { get; set; }
        public int IntelligenceAmplifier { get; set; }
        public int Level { get; set; } = 0;
        public int UpgradeCost { get; set; } = 0;
        public List<GeneratedProduct> OccupationProduces { get; set; }

        public Occupation(string name, int StrAmpl, int IntAmpl, int UpCost)
        {
            Name = name;
            StrengthAmplifier = StrAmpl;
            IntelligenceAmplifier = IntAmpl;
            UpgradeCost = UpCost;
        }
        public override string ToString()
        {
            return $"{Name}(Lvl{Level})";
        }



    }
}
