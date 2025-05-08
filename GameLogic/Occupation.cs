using System;
using System.Collections.Generic;

namespace GameLogic
{
    public class Occupation
    {
        Random rnd = new Random();
        public string Name { get; set; }
        public int StrengthAmplifier { get; set; }
        public int IntelligenceAmplifier { get; set; }
        public List<GeneratedProduct> OccupationProduces { get; set; }

        public Occupation(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }



    }
}
