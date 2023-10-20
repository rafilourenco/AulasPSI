using System;
namespace NPCPerks
{
    [Flags]
    public enum Traits
    {
        Sturdy = 1 << 0,
        Agile = 1 << 1,
        Strong = 1 << 2,
        Intelligent = 1 << 3,
        Wisdom = 1 << 4,
        Deceitful = 1 << 5,
        FastLearner = 1 << 6

    }
}