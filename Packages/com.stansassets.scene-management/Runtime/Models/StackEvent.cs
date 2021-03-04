using System;

namespace StansAssets.SceneManagement
{
    public abstract class StackEvent<TEnum> where TEnum : Enum
    {
        public TEnum State { get; protected set; }
    }
}
