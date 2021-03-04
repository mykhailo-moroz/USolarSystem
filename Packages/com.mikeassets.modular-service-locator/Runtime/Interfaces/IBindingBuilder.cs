namespace MikeAssets.ModularServiceLocator.Interfaces
{
    public interface IBindingBuilder<T>
    {
        void To<TImplementation>() where TImplementation : T;
        void ToConstant(object constant);
    }
    
    public interface IBindingBuilder<T1, T2>
    {
        void To<TImplementation>() where TImplementation : T1, T2;
        void ToConstant(object constant);
    }
}