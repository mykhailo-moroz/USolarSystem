using System;

namespace SolarSystem.Models
{
    public abstract class StackEvent<TEnum> where TEnum : Enum
    {
        public TEnum State { get; protected set; }
    }
}
