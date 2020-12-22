using System;
using System.Collections.Generic;
using SolarSystem.Enums;
using StansAssets.Foundation.Patterns;

namespace SolarSystem.Models
{
    public class StackOperationEvent<TEnum> : StackEvent<TEnum> where TEnum : Enum
    {
        static readonly DefaultPool<StackOperationEvent<TEnum>> s_EventsPool = new DefaultPool<StackOperationEvent<TEnum>>();

        public StackOperation Operation { get; private set; }
        public IReadOnlyList<TEnum>  OldStackValue { get; protected set; }
        public IReadOnlyList<TEnum>  NewStackValue { get; protected set; }
        
        public static StackOperationEvent<TEnum> GetPooled(StackOperation operation, TEnum state, IReadOnlyList<TEnum> oldStackValue, IReadOnlyList<TEnum> newStackValue)
        {
            var e = s_EventsPool.Get();
            e.Operation = operation;
            e.State = state;
            e.OldStackValue = oldStackValue;
            e.NewStackValue = newStackValue;

            return e;
        }

        public static void Release(StackOperationEvent<TEnum> stackChangeEvent)
        {
            s_EventsPool.Release(stackChangeEvent);
        }
    }
}
