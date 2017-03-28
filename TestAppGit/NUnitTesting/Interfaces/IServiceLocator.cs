namespace NUnitTesting.Interfaces
{
    interface IServiceLocator
    {
        T GetService<T>();
    }
}
