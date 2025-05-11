using System;

namespace GameLogic
{
    [Serializable]
    public class GeneratedProduct : ICloneable
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Saturation { get; set; }
        public int Count { get; set; }
        public int ObtainDifficulty { get; set; }
        public int AmountOfWorkNeed { get; set; }
        public int CurrentWorkProgress { get; set; } = 0;
        public Occupation BelongsToOccup { get; set; }

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
