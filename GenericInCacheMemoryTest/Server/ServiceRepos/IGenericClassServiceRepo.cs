using GenericInCacheMemoryTest.Shared;

namespace GenericInCacheMemoryTest.Server.ServiceRepos
{
    public interface IGenericClassServiceRepo
    {
        void AddGenericClass(GenericClass[] genericClasses);
        GenericClass[] GetGenericClasses();
    }
}