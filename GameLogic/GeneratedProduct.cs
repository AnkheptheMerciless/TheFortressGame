using System;

namespace GameLogic
{
    public class GeneratedProduct : ICloneable
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Saturation { get; set; }
        public int Count { get; set; }
        public int ObtainDifficulty { get; set; }
        public Occupation BelongsToOccup { get; set; }
        public int AmountOfWorkNeed { get; set; }
        public int CurrentWorkProgress { get; set; } = 0;

        public override string ToString()
        {
            return $"{Name} {Price} {Count}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
