namespace Doroga.Infrastructure.Common
{
    public interface IDependencyResolver
    {
        T Resolve<T>();
    }
}
