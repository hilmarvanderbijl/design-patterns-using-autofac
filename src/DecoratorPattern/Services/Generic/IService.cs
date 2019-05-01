namespace DecoratorPattern.Services.Generic
{
    public interface IService<T>
    {
        void Add(T itemToAdd);
    }
}