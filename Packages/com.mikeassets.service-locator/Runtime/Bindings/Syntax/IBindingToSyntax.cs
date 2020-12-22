using System;

namespace MikeAssets.ServiceLocator.Bindings.Syntax
{
    public interface IBindingToSyntax<in T>
    {
        IBindingWhenInNamedWithOrOnSyntax<TImplementation> To<TImplementation>() where TImplementation : T;
        IBindingWhenInNamedWithOrOnSyntax<object> To(Type implementation);
        IBindingWhenInNamedWithOrOnSyntax<TImplementation> To<TImplementation>(TImplementation implementation)
            where TImplementation : T;
    }

    public interface IBindingToSyntax<in T1, in T2>
    {
        IBindingWhenInNamedWithOrOnSyntax<TImplementation> To<TImplementation>() where TImplementation : T1, T2;
        IBindingWhenInNamedWithOrOnSyntax<TImplementation> To<TImplementation>(TImplementation implementation)
            where TImplementation : T1, T2;
    }
}