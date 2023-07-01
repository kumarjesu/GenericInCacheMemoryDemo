using GenericInCacheMemoryTest.Shared;
using Microsoft.Extensions.Caching.Memory;

namespace GenericInCacheMemoryTest.Server.ServiceRepos
{
    public class GenericClassServiceRepo : IGenericClassServiceRepo
    {
        private const string KEY = "LUSID";
        private readonly IMemoryCache _memoryCache;

        public GenericClassServiceRepo(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public void AddGenericClass(GenericClass[] genericClasses)
        {
            var cache = new MemoryCache(new MemoryCacheOptions
            {
                SizeLimit = long.MaxValue,
            });

            var option = new MemoryCacheEntryOptions
            {
                SlidingExpiration = TimeSpan.FromSeconds(30),
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(90)
            };

            _memoryCache.Set<GenericClass[]>(KEY, genericClasses, option);
        }


        public GenericClass[] GetGenericClasses()
        {
            GenericClass[] genericClasses;

            if (!_memoryCache.TryGetValue(KEY, out genericClasses))
            {
                genericClasses = new GenericClass[]
                {
                     new GenericClass{ MyProperty1=111, MyProperty2 = "Finbourne 1", MyProperty3=DateOnly.Parse("05/04/2023"), MyProperty4=74756.85},
                     new GenericClass{ MyProperty1=211, MyProperty2 = "Finbourne 2", MyProperty3=DateOnly.Parse("30/04/2023"), MyProperty4=65478.95},
                     new GenericClass{ MyProperty1=311, MyProperty2 = "Finbourne 3", MyProperty3=DateOnly.Parse("05/05/2023"), MyProperty4=70124.95},
                     new GenericClass{ MyProperty1=411, MyProperty2 = "Finbourne 4", MyProperty3=DateOnly.Parse("15/05/2023"), MyProperty4=60000.05},
                     new GenericClass{ MyProperty1=511, MyProperty2 = "Finbourne 5", MyProperty3=DateOnly.Parse("30/05/2023"), MyProperty4=55000.00},
                     new GenericClass{ MyProperty1=611, MyProperty2 = "Finbourne 6", MyProperty3=DateOnly.Parse("05/06/2023"), MyProperty4=85000.25},
                     new GenericClass{ MyProperty1=711, MyProperty2 = "Finbourne 7", MyProperty3=DateOnly.Parse("15/06/2023"), MyProperty4=65000.75},
                     new GenericClass{ MyProperty1=811, MyProperty2 = "Finbourne 8", MyProperty3=DateOnly.Parse("30/06/2023"), MyProperty4=75000.05},
                };
                AddGenericClass(genericClasses);
            }
            Thread.Sleep(05);

            return genericClasses;
        }
    }
}
